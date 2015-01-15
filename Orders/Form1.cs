using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SQLite;
using Orders.Classes;
using Orders.Properties;
using Button = System.Windows.Forms.Button;

namespace Orders
{
    public partial class Form1 : Form
    {
        private DataTable _workType;
        private DataTable _consType;
        private DataTable _sourceType;
        private bool _hasChange;
        private readonly Dictionary<int, int> _workCons = new Dictionary<int, int>();
        private readonly Dictionary<int, int> _certCons = new Dictionary<int, int>(); 

        private enum TableCol
        {
            TypeColIndex = 4,
            //NameColIndex = 4,
            PreDateColIndex = 6,
            ExDateColIndex = 9,
            //ConsColIndex = 8,
            SourColIndex = 11,
            //SertColIndex = 15,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void WorkLoad()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS Id,W.fClientId AS ClientId,Wt.fId AS Type," +
                                     "date(W.fDate, 'unixepoch') AS Date," +
                                     "W.fPrepay AS Prepay," + 
                                     "W.fExcess AS Excess,W.fHours AS Hours,S.fId AS Source," +
                                     "SUM(CASE WHEN Cs.fAmount IS NULL THEN 0 ELSE Cs.fAmount END) AS Cons," +
                                     "W.fSertId AS Sert,C.fName AS Client,P.fName AS PayerName," +
                                     "date(W.fExcessDate, 'unixepoch') AS ExDate " +
                                     "FROM tWork W " +
                                     "JOIN tClient C ON W.fClientId=C.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId " +
                                     "JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "LEFT JOIN tSert Sr ON Sr.fId=W.fSertId " +
                                     "LEFT JOIN tClient P ON Sr.fPayId=P.fId " +
                                     "LEFT JOIN tCons Cs ON Cs.fWorkId=W.fId " +
                                     //"AND Cs.fCertCons=0 " +
                                     "GROUP BY Id,ClientId,Type,Date,Prepay,Excess,Hours,Source,Sert,Client,ExDate," +
                                     "PayerName ORDER BY Date,Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                var currDate = DateTime.Now;
                grWork.Rows.Clear();
                //grWork.RowCount = 1;
                foreach (DataRow row in wkTable.Rows)
                {
                    var work = new Work(row);
                
                    if (work.Date.Year != currDate.Year) continue;
                   

                    if (work.Date.Month != currDate.Month) continue;
                    grWork.RowCount = grWork.RowCount + 1;
                    var iRow = grWork.Rows[grWork.RowCount - 2].Cells;
                    iRow["cNumber"].Value = grWork.RowCount - 1;
                    iRow["cId"].Value = work.Id;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                  /*  c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType > 0)
                        c.Value = work.ConsType;*/
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;

                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    //iRow["cSert"].Value = work.Sert > 0;
                    iRow["cCertId"].Value = work.Sert;
                    iRow["cExDate"].Value = work.ExDate == null
                        ? ""
                        : work.ExDate.Value.ToString("dd.MM.yyyy");
                    var bc = iRow["cSert"] as DataGridViewButtonCell;
                    if (bc != null) bc.Value = work.PayerName;

                    
                }
                _hasChange = false;
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void GraphLoad()
        {
            var yStart = new DateTime(DateTime.Now.Year, 1, 1);
            var mStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var chartData = new DataTable();
                const string selCmd =
                    "SELECT DISTINCT T.fName AS Type,COUNT(W.fId) AS Count,SUM((fPrepay+fExcess)/1000) AS Income " +
                    "FROM tWork W JOIN tWorkType T ON W.fTypeId=T.fId " +
                    "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end) " +
                    "GROUP BY fTypeId";
                var adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(selCmd, conn)};
                adapter.SelectCommand.Parameters.AddWithValue("start", mStart);
                adapter.SelectCommand.Parameters.AddWithValue("end", mStart.AddMonths(1));
                adapter.SelectCommand.Prepare();
                adapter.Fill(chartData);
                chMonth.Series["count"].XValueMember = "Type";
                chMonth.Series["count"].YValueMembers = "Count";
                chMonth.Series["income"].XValueMember = "Type";
                chMonth.Series["income"].YValueMembers = "Income";
                chMonth.DataSource = chartData;
                chMonth.DataBind();
                
                chartData = new DataTable();
                adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(selCmd, conn)};
                adapter.SelectCommand.Parameters.AddWithValue("start", yStart);
                adapter.SelectCommand.Parameters.AddWithValue("end", yStart.AddYears(1));
                adapter.SelectCommand.Prepare();
                adapter.Fill(chartData);
                chYear.Series["count"].XValueMember = "Type";
                chYear.Series["count"].YValueMembers = "Count";
                chYear.Series["income"].XValueMember = "Type";
                chYear.Series["income"].YValueMembers = "Income";
                chYear.DataSource = chartData;
                chYear.DataBind();

                var chartConsData = new DataTable();
                const string cnsCmd =
                    "SELECT DISTINCT T.fName AS Type,COUNT(C.fId) AS Count,SUM(fAmount/1000) AS Cons " +
                    "FROM tCons C JOIN tConsType T ON C.fTypeId=T.fId " +
                    "WHERE C.fDate>=strftime('%s', :start) AND C.fDate<strftime('%s', :end) " +
                    "GROUP BY fTypeId";
                var adCons = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(cnsCmd, conn) };
                adCons.SelectCommand.Parameters.AddWithValue("start", mStart);
                adCons.SelectCommand.Parameters.AddWithValue("end", mStart.AddMonths(1));
                adCons.SelectCommand.Prepare();
                adCons.Fill(chartConsData);
                chCMonth.Series["count"].XValueMember = "Type";
                chCMonth.Series["count"].YValueMembers = "Count";
                chCMonth.Series["cons"].XValueMember = "Type";
                chCMonth.Series["cons"].YValueMembers = "Cons";
                chCMonth.DataSource = chartConsData;
                chCMonth.DataBind();

                chartConsData = new DataTable();
                adCons = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(cnsCmd, conn) };
                adCons.SelectCommand.Parameters.AddWithValue("start", yStart);
                adCons.SelectCommand.Parameters.AddWithValue("end", yStart.AddYears(1));
                adCons.SelectCommand.Prepare();
                adCons.Fill(chartConsData);
                chCYear.Series["count"].XValueMember = "Type";
                chCYear.Series["count"].YValueMembers = "Count";
                chCYear.Series["cons"].XValueMember = "Type";
                chCYear.Series["cons"].YValueMembers = "Cons";
                chCYear.DataSource = chartConsData;
                chCYear.DataBind();
            }
            finally
            {
                conn.Close();
            }
        }

        private void ConsLoad()
        {
            var mStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var consData = new DataTable();
                const string selCmd =
                    "SELECT DISTINCT 1 AS csNumber, C.fId AS csId,C.fTypeId AS csType,C.fAmount AS csAmount," +
                    "strftime('%d.%m.%Y',date(C.fDate, 'unixepoch')) AS csDate,C.fComment AS csComment " +
                    "FROM tCons C JOIN tConsType T ON C.fTypeId=T.fId " +
                    "WHERE C.fDate>=strftime('%s', :start) AND C.fDate<strftime('%s', :end)" + " AND C.fWorkId=0 AND C.fCertId=0 " +
                    "ORDER BY C.fDate";
                var adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(selCmd, conn)};
                adapter.SelectCommand.Parameters.AddWithValue("start", mStart);
                adapter.SelectCommand.Parameters.AddWithValue("end", mStart.AddMonths(1));
                adapter.SelectCommand.Prepare();
                adapter.Fill(consData);

                var i = 0;
                foreach (DataRow row in consData.Rows)
                {
                    i++;
                    row["csNumber"] = i;
                }

                var bSource = new BindingSource {DataSource = consData};
                grCons.DataSource = bSource;

            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void CertLoad()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var certData = new DataTable();
                const string selCmd = "SELECT DISTINCT 1 AS ccNumber, S.fId AS ccId,S.fPayId AS ccPayerId,P.fName AS ccPayerName," +
                                      "S.fClientId AS ccClientId,C.fName AS ccClientName,S.fTypeId AS ccTypeId," +
                                      "strftime('%d.%m.%Y',date(S.fDatePay, 'unixepoch')) AS ccDatePay," +
                                      "strftime('%d.%m.%Y',date(S.fDateEnd, 'unixepoch')) AS ccDateEnd," +
                                      "S.fPrice AS ccPrice,S.fHours AS ccHours,S.fSource AS ccSource,SUM(Cs.fAmount) AS ccCons " +
                                      "FROM tSert S JOIN tClient P ON S.fPayId=P.fId JOIN tClient C ON S.fClientId=C.fId " +
                                      "LEFT JOIN tCons Cs ON S.fId=Cs.fCertId " +
                                      "WHERE NOT EXISTS (SELECT DISTINCT fSertId FROM tWork WHERE fSertId=S.fId) " +
                                      "GROUP BY ccNumber,ccId,ccPayerId,ccPayerName,ccClientId,ccClientName,ccTypeId," +
                                      "ccDatePay,ccDateEnd,ccPrice,ccHours,ccSource ORDER BY S.fDateEnd";
                var adapter = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(selCmd, conn) };
                adapter.Fill(certData);
                
                var i = 0;
                foreach (DataRow row in certData.Rows)
                {
                    i++;
                    row["ccNumber"] = i;
                }

                var bSource = new BindingSource { DataSource = certData };
                grCert.DataSource = bSource;
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void ControlLoad()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                _workType = new DataTable();
                _sourceType = new DataTable();
                _consType = new DataTable();
                var adapter = new SQLiteDataAdapter
                {
                    SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tWorkType", conn)
                };
                adapter.Fill(_workType);
                adapter.SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tSource", conn);
                adapter.Fill(_sourceType);
                adapter.SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tConsType", conn);
                adapter.Fill(_consType);
                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "cTypeA",
                    DataSource = _workType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Type,
                    Width = 120
                };
                grWork.Columns.Insert((int) TableCol.TypeColIndex, combo);
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "cSourceA",
                    DataSource = _sourceType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Source,
                    Width = 120
                };
                grWork.Columns.Insert((int) TableCol.SourColIndex, combo);

                /*combo = new DataGridViewComboBoxColumn
                {
                    Name = "cConsA",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.ConsType
                };
                grWork.Columns.Insert((int) TableCol.ConsColIndex, combo);*/
                var date = new CalendarColumn
                {
                    Name = "cPreDate",
                    DataPropertyName = "cPreDate",
                    HeaderText = Resources.Date,
                    Width = 120
                };
                grWork.Columns.Insert((int) TableCol.PreDateColIndex, date);

                date = new CalendarColumn
                {
                    Name = "cExDate",
                    DataPropertyName = "cExDate",
                    HeaderText = Resources.ExDate,
                    Width = 120
                };
                grWork.Columns.Insert((int) TableCol.ExDateColIndex, date);


                date = new CalendarColumn
                {
                    Name = "ccDateEnd",
                    DataPropertyName = "ccDateEnd",
                    HeaderText = Resources.DateEnd,
                    Width = 120
                };
                grCert.Columns.Insert(6, date);
                
                date = new CalendarColumn
                {
                    Name = "ccDatePay",
                    DataPropertyName = "ccDatePay",
                    HeaderText = Resources.DatePay,
                    Width = 120
                };
                grCert.Columns.Insert(6, date);

                combo = new DataGridViewComboBoxColumn
                {
                    Name = "ccSource",
                    DataPropertyName = "ccSource",
                    DataSource = _sourceType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Source,
                    Width = 120
                };
                grCert.Columns.Insert(6, combo); 
                
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "ccType",
                    DataPropertyName = "ccTypeId",
                    DataSource = _workType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Type,
                    Width = 120
                };
                grCert.Columns.Insert(6, combo);
                
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "csType",
                    DataPropertyName = "csType",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    Width = 120,
                    HeaderText = Resources.ConsType
                };
                grCons.Columns.Insert(2, combo);
                date = new CalendarColumn
                {
                    Name = "csDate",
                    DataPropertyName = "csDate",
                    HeaderText = Resources.Date,
                    Width = 120
                };
                grCons.Columns.Insert(3, date);
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void DictLoad()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var certData = new DataTable();
                const string selCmd = "SELECT DISTINCT fId,fName,fPhone,fEmail,fNote " +
                                      "FROM tClient ORDER BY fName";
                var adapter = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(selCmd, conn) };
                adapter.Fill(certData);


                var bSource = new BindingSource { DataSource = certData };
                grDicClient.DataSource = bSource;
                bSource = new BindingSource { DataSource = _workType };
                grDicWork.DataSource = bSource;
                bSource = new BindingSource { DataSource = _consType };
                grDicCons.DataSource = bSource;
                bSource = new BindingSource { DataSource = _sourceType };
                grDicSource.DataSource = bSource;
                /*for (var i = 0; i < grCert.Rows.Count; i++)
                {
                    grCert.Rows[i].Cells["ccNumber"].Value = i.ToString(CultureInfo.InvariantCulture);
                }*/
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void StatLoad()
        {
            var currDate = DateTime.Now;
            var cYear = ClassWork.GetYearStat(currDate.Year);
            var pYear = ClassWork.GetYearStat(currDate.Year - 1);
            lMonthC.Text = currDate.ToString("MMMM");

            var cMonth = cYear.Find(st => st.Month == currDate.Month);
            lIncomeC.Text = cMonth.Income.ToString("### ### ##0");
            lConsC.Text = cMonth.Cons.ToString("### ### ##0");
            lProfitC.Text = (cMonth.Income - cMonth.Cons).ToString("### ### ##0");
            lHoursC.Text = cMonth.Hours.ToString();


            lIncomeY.Text = cYear.Sum(st => st.Income).ToString("### ### ##0");
            lConsY.Text = cYear.Sum(st => st.Cons).ToString("### ### ##0");
            lProfitY.Text = cYear.Sum(st => st.Income - st.Cons).ToString("### ### ##0");
            lHoursY.Text = cYear.Sum(st => st.Hours).ToString();
            lIncomeYA.Text = (cYear.Sum(st => st.Income) / currDate.Month).ToString("### ### ##0");

            lYearC.Text = currDate.Year.ToString("D");
            lYearL.Text = (currDate.Year - 1).ToString("D");
            lSumCAll.Text = cYear.Sum(st => st.Income).ToString("### ### ##0");
            lSumLAll.Text = pYear.Sum(st => st.Income).ToString("### ### ##0");
            foreach (var stat in cYear)
            {
                Controls.Find("lSumC" + stat.Month, true)[0].Text = stat.Income.ToString("### ### ##0");
            }
            foreach (var stat in pYear)
            {
                Controls.Find("lSumL" + stat.Month, true)[0].Text = stat.Income.ToString("### ### ##0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StatLoad();
            ControlLoad();
            WorkLoad();
            GraphLoad();
            ConsLoad();
            CertLoad();
            DictLoad();
            tabArchive.Dispose();
        }

        private void History_Click(object sender, EventArgs e)
        {
            if (_hasChange)
            {
                var svResult = MessageBox.Show(Resources.ChangeData, Resources.Orders, MessageBoxButtons.YesNo);
                if (svResult == DialogResult.Yes)
                {
                    SaveChanges();
                }
            }
            var button = sender as Button;
            if (button == null) return;
            GridMonthLoad(Convert.ToInt32(button.Tag), DateTime.Now.Year);
            _hasChange = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void GridMonthLoad(int month, int year)
        {
            var sDate = new DateTime(year, month, 1);
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            var eDate = new DateTime(year, month, 1);
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS Id,W.fClientId AS ClientId,Wt.fId AS Type," +
                                     "date(W.fDate, 'unixepoch') AS Date," +
                                     "W.fPrepay AS Prepay," +
                                     "W.fExcess AS Excess,W.fHours AS Hours,S.fId AS Source," +
                                     "SUM(CASE WHEN Cs.fAmount IS NULL THEN 0 ELSE Cs.fAmount END) AS Cons," +
                                     "W.fSertId AS Sert,C.fName AS Client,date(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "P.fName AS PayerName " +
                                     "FROM tWork W " +
                                     "JOIN tClient C ON W.fClientId=C.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId " +
                                     "JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "LEFT JOIN tSert Sr ON Sr.fId=W.fSertId " +
                                     "LEFT JOIN tClient P ON Sr.fPayId=P.fId " +
                                     "LEFT JOIN tCons Cs ON Cs.fWorkId=W.fId AND Cs.fCertCons=0 " +
                                    // "LEFT JOIN tCons CCs ON CCs.fWorkId=W.fId AND CCs.fCertCons=1 " +
                                     "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end) " +
                                     "GROUP BY Id,ClientId,Type,Date,Prepay,Excess,Hours,Source,Sert,Client,ExDate," +
                                     "PayerName " +
                                     "ORDER BY Date,Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                wkCom.Parameters.AddWithValue("start", sDate);
                wkCom.Parameters.AddWithValue("end", eDate);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                var inc = 0D;
                var con = 0D;
                var hrs = 0D;
                grWork.RowCount = 1;
                foreach (var work in from DataRow row in wkTable.Rows select new Work(row))
                {
                    grWork.RowCount = grWork.RowCount + 1;
                    var iRow = grWork.Rows[grWork.RowCount - 2].Cells;
                    iRow["cNumber"].Value = grWork.RowCount - 1;
                    iRow["cId"].Value = work.Id;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                    /*c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType > 0)
                        c.Value = work.ConsType;*/
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;
                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    iRow["cSert"].Value = work.PayerName;
                    iRow["cExDate"].Value = work.ExDate == null
                        ? ""
                        : work.ExDate.Value.ToString("dd.MM.yyyy");
                    inc += work.Prepay + work.Excess;
                    con += work.Cons;
                    hrs += work.Hours;
                }
                lMonthC.Text = sDate.ToString("MMMM");
                lIncomeC.Text = inc.ToString("### ### ##0");
                lConsC.Text = con.ToString("### ### ##0");
                lProfitC.Text = (inc - con).ToString("### ### ##0");
                lHoursC.Text = hrs.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        private void grWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grWork.Columns[iCol].Name)
            {
                case "cSert":
                    var frCert = new FrCert();
                    try
                    {
                        frCert.Cert = new Cert {Id = Convert.ToInt32(grWork.Rows[iRow].Cells["cCertId"].Value)};
                    }
                    catch 
                    {
                        frCert.Cert = new Cert { Id = 0};
                    }
                    frCert.ShowDialog();
                    if(frCert.Cert==null|| !frCert.FrOk) return;
                    grWork.Rows[iRow].Cells["cSert"].Value = frCert.Cert.PayName;
                    grWork.Rows[iRow].Cells["cCertId"].Value = frCert.Cert.Id;
                    grWork.Rows[iRow].Cells["cClientId"].Value = frCert.Cert.Clientid;
                    grWork.Rows[iRow].Cells["cClient"].Value = frCert.Cert.ClientName;
                    grWork.Rows[iRow].Cells["cTypeA"].Value = frCert.Cert.TypeId;
                    grWork.Rows[iRow].Cells["cPrepay"].Value = frCert.Cert.Price;
                    grWork.Rows[iRow].Cells["cPreDate"].Value = frCert.Cert.DatePay;
                    grWork.Rows[iRow].Cells["cCons"].Value = frCert.Cert.Cons;
                    grWork.Rows[iRow].Cells["cHours"].Value = frCert.Cert.Hours;
                    grWork.Rows[iRow].Cells["cSourceA"].Value = frCert.Cert.Source;

                    break;
                case "cCons":
                    var frCons = new FrCons();
                    try
                    {
                        frCons.WorkDate = Convert.ToDateTime(grWork.Rows[iRow].Cells["cPreDate"].Value);
                    }
                    catch (Exception)
                    {
                        frCons.WorkDate = DateTime.Now;
                    }
                    frCons.CertId = 0;
                    try
                    {
                        frCons.WorkId = Convert.ToInt32(grWork.Rows[iRow].Cells["cId"].Value);
                        frCons.ConsId = new List<int>();
                    }
                    catch (Exception)
                    {
                        frCons.WorkId = 0;
                        frCons.ConsId = new List<int>();
                        foreach (var con in _workCons.Where(c=>c.Value==iRow))
                        {
                            frCons.ConsId.Add(con.Key);
                        }
                    }
                    frCons.ShowDialog();
                    if (frCons.Cons == null || !frCons.FrOk) return;

                    if (frCons.WorkId == 0)
                    {
                        var remove = _workCons.Where(c => c.Value == iRow).Select(con => con.Key).ToList();
                        foreach (var item in remove)
                        {
                            _workCons.Remove(item);
                        }
                        foreach (var i in frCons.ConsId)
                        {
                            _workCons.Add(i, iRow);
                        }
                    }
                    grWork.Rows[iRow].Cells[iCol].Value = frCons.Cons.Amount;
                    GraphLoad();
                    break;
                case "cClient":
                    var fr = new FrClient();
                    fr.ShowDialog();
                    grWork.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                    grWork.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    break;
            }
        }

        private void SaveChanges()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tWork (fClientId,fTypeId,fDate," +
                                      "fPrepay,fExcess,fExcessDate,fHours,fSourceId,fSertId) " +
                                      "VALUES(:client,:type,strftime('%s', :date),:prepay,:excess," +
                                      "CASE WHEN :excess<1 THEN NULL ELSE strftime('%s', :exdate) END," +
                                      ":hour,:source,CASE WHEN :sert=0 THEN NULL ELSE :sert END);" +
                                      "SELECT DISTINCT last_insert_rowid() FROM tWork";
                const string updCmd = "UPDATE tWork SET fClientId=:client,fTypeId=:type,fDate=strftime('%s', :date)," +
                                      "fPrepay=:prepay,fExcess=:excess," +
                                      "fExcessDate=CASE WHEN :excess<1 THEN NULL ELSE strftime('%s', :exdate) END," +
                                      "fHours=:hour,fSourceId=:source," +
                                      "fSertId=CASE WHEN :sert=0 THEN NULL ELSE :sert END " +
                                      "WHERE fId=:id";
                const string cnsCmd = "UPDATE tCons SET fWorkId=:work WHERE fId=:id";
                const string cnsCertCmd = "UPDATE tCons SET fWorkId=:work WHERE fCertId=:id";
                foreach (DataGridViewRow row in grWork.Rows)
                {
                    if(row.Cells["cClientId"].Value==null) continue;
                    
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("client", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("type", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("date", DbType.DateTime));
                    insCom.Parameters.Add(new SQLiteParameter("prepay", DbType.Double));
                    insCom.Parameters.Add(new SQLiteParameter("excess", DbType.Double));
                    insCom.Parameters.Add(new SQLiteParameter("exdate", DbType.DateTime));
                    insCom.Parameters.Add(new SQLiteParameter("hour", DbType.Double));
                    insCom.Parameters.Add(new SQLiteParameter("source", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("sert", DbType.Int32));
                    //var a = grWork.Rows[i].Cells["cTypeA"].Value;
                    if (row.Cells["cId"].Value == null)
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = row.Cells["cId"].Value;
                    }
                    insCom.Parameters["client"].Value = Convert.ToInt32(row.Cells["cClientId"].Value);
                    insCom.Parameters["type"].Value = Convert.ToInt32(row.Cells["cTypeA"].Value);
                    insCom.Parameters["source"].Value = Convert.ToInt32(row.Cells["cSourceA"].Value);
                    insCom.Parameters["sert"].Value = Convert.ToInt32(row.Cells["cCertId"].Value);
                    insCom.Parameters["date"].Value =
                        DateTime.Parse(row.Cells["cPreDate"].Value.ToString());
                    insCom.Parameters["prepay"].Value = row.Cells["cPrepay"].Value;
                    insCom.Parameters["excess"].Value = row.Cells["cExcess"].Value == null ||
                                                        string.IsNullOrEmpty(
                                                            row.Cells["cExcess"].Value.ToString()) ||
                                                        Convert.ToDouble(row.Cells["cExcess"].Value) < 0.01
                        ? 0
                        : row.Cells["cExcess"].Value;
                    insCom.Parameters["exdate"].Value =
                        row.Cells["cExcess"].Value == null ||
                        string.IsNullOrEmpty(row.Cells["cExcess"].Value.ToString()) ||
                        Convert.ToDouble(row.Cells["cExcess"].Value) < 0.01
                            ? DateTime.Now
                            : DateTime.Parse(row.Cells["cExDate"].Value.ToString());
                    insCom.Parameters["hour"].Value = row.Cells["cHours"].Value;
                    insCom.Prepare();
                    var insDr = insCom.ExecuteReader();
                    while (insDr.Read())
                    {
                        var id = Convert.ToInt32(insDr[0]);
                        var remove = new List<int>();
                        DataGridViewRow row1 = row;
                        foreach (var con in _workCons.Where(c => c.Value == row1.Index))
                        {
                            var cnsCom = new SQLiteCommand(cnsCmd, conn);
                            cnsCom.Parameters.AddWithValue("id", con.Key);
                            cnsCom.Parameters.AddWithValue("work", id);
                            cnsCom.Prepare();
                            cnsCom.ExecuteNonQuery();
                            remove.Add(con.Key);
                        }
                        foreach (var item in remove)
                        {
                            _workCons.Remove(item);
                        }
                        if (Convert.ToInt32(row.Cells["cCertId"].Value) <= 0) continue;
                        var cnsCertCom = new SQLiteCommand(cnsCertCmd, conn);
                        cnsCertCom.Parameters.AddWithValue("id", Convert.ToInt32(row.Cells["cCertId"].Value));
                        cnsCertCom.Parameters.AddWithValue("work", id);
                        cnsCertCom.Prepare();
                        cnsCertCom.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                _hasChange = false;
                GraphLoad();
                WorkLoad();
                CertLoad();
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void SaveCerts()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tSert " +
                                      "(fPayId,fClientId,fTypeId,fDatePay,fDateEnd,fPrice,fHours,fSource) " +
                                      "VALUES(:payer,:client,:type,strftime('%s',:datepay),strftime('%s',:dateend)," +
                                      ":price,:hour,:source);" +
                                      "SELECT DISTINCT last_insert_rowid() FROM tSert";
                const string updCmd = "UPDATE tSert SET fPayId=:payer,fClientId=:client,fTypeId=:type,fDatePay=strftime('%s',:datepay)," +
                                      "fDateEnd=strftime('%s',:dateend),fPrice=:price,fHours=:hour,fSource=:source " +
                                      "WHERE fId=:id";
                const string cnsCmd = "UPDATE tCons SET fCertId=:cert WHERE fId=:id";
                for (var i = 0; i < grCert.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("payer", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("client", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("type", DbType.Int32));
                    insCom.Parameters.Add(new SQLiteParameter("datepay", DbType.DateTime));
                    insCom.Parameters.Add(new SQLiteParameter("dateend", DbType.DateTime));
                    insCom.Parameters.Add(new SQLiteParameter("price", DbType.Double));
                    insCom.Parameters.Add(new SQLiteParameter("hour", DbType.Double));
                    insCom.Parameters.Add(new SQLiteParameter("source", DbType.Int32));
                    if (grCert.Rows[i].Cells["ccId"].Value == null || string.IsNullOrEmpty(grCert.Rows[i].Cells["ccId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grCert.Rows[i].Cells["ccId"].Value;
                    }
                    insCom.Parameters["payer"].Value = Convert.ToInt32(grCert.Rows[i].Cells["ccPayerId"].Value);
                    insCom.Parameters["client"].Value = Convert.ToInt32(grCert.Rows[i].Cells["ccClientId"].Value);
                    insCom.Parameters["type"].Value = Convert.ToInt32(grCert.Rows[i].Cells["ccType"].Value);
                    try
                    {
                        insCom.Parameters["datepay"].Value =
                            DateTime.Parse(grCert.Rows[i].Cells["ccDatePay"].Value.ToString());
                    }
                    catch
                    {
                        insCom.Parameters["datepay"].Value = DateTime.Now;
                    }
                    try
                    {
                        insCom.Parameters["dateend"].Value =
                            DateTime.Parse(grCert.Rows[i].Cells["ccDateEnd"].Value.ToString());
                    }
                    catch
                    {
                        insCom.Parameters["dateend"].Value = DateTime.Now.AddMonths(3);
                    }
                    insCom.Parameters["price"].Value = grCert.Rows[i].Cells["ccPrice"].Value;
                    insCom.Parameters["hour"].Value = grCert.Rows[i].Cells["ccHours"].Value;
                    insCom.Parameters["source"].Value = Convert.ToInt32(grCert.Rows[i].Cells["ccSource"].Value);
                    insCom.Prepare();
                    var insDr = insCom.ExecuteReader();
                    while (insDr.Read())
                    {
                        var id = Convert.ToInt32(insDr[0]);
                        var remove = new List<int>();
                        var i1 = i;
                        foreach (var con in _certCons.Where(c => c.Value == i1))
                        {
                            var cnsCom = new SQLiteCommand(cnsCmd, conn);
                            cnsCom.Parameters.AddWithValue("id", con.Key);
                            cnsCom.Parameters.AddWithValue("cert", id);
                            cnsCom.Prepare();
                            cnsCom.ExecuteNonQuery();
                            remove.Add(con.Key);
                        }
                        foreach (var item in remove)
                        {
                            _certCons.Remove(item);
                        }
                    }
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                GraphLoad();
                CertLoad();
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void SaveCons()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tCons (fTypeId,fAmount,fDate,fComment) " +
                                      "VALUES(:type,:amount,strftime('%s', :date),:comment)";
                const string updCmd = "UPDATE tCons SET fTypeId=:type,fAmount=:amount,fComment=:comment," +
                                      "fDate=strftime('%s', :date) WHERE fId=:id";
                var insCom = new SQLiteCommand(conn);
                insCom.Parameters.Add(new SQLiteParameter("type", DbType.Int32));
                insCom.Parameters.Add(new SQLiteParameter("amount", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("date", DbType.DateTime));
                insCom.Parameters.Add(new SQLiteParameter("comment", DbType.AnsiString));
                foreach (DataGridViewRow row in grCons.Rows)
                {
                    if (row.Cells["csId"].Value == null) continue;
                    if(string.IsNullOrEmpty(row.Cells["csId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = Convert.ToInt32(row.Cells["csId"].Value);
                    }
                    insCom.Parameters["date"].Value = DateTime.Parse(row.Cells["csDate"].Value.ToString());
                    insCom.Parameters["type"].Value = row.Cells["csType"].Value;
                    insCom.Parameters["amount"].Value = row.Cells["csAmount"].Value;
                    insCom.Parameters["comment"].Value = row.Cells["csComment"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                //_hasChange = false;
                ConsLoad();
                GraphLoad();
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_hasChange) return;
            var svResult = MessageBox.Show(Resources.ChangeData, Resources.Orders, MessageBoxButtons.YesNo);
            if (svResult == DialogResult.Yes)
            {
                SaveChanges();
            }
        }

        private void grWork_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
        }

        private void btConsSave_Click(object sender, EventArgs e)
        {
            SaveCons();
        }
        
        private void SourceSave(out Exception exception)
        {
            exception = null;
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tSource (fName) VALUES(:name)";
                const string updCmd = "UPDATE tSource SET fName=:name WHERE fId=:id";
                for (var i = 0; i < grDicSource.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("name", DbType.String));
                    if (string.IsNullOrEmpty(grDicSource.Rows[i].Cells["cdsId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grDicSource.Rows[i].Cells["cdsId"].Value;
                    }
                    insCom.Parameters["name"].Value = grDicSource.Rows[i].Cells["cdsName"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                _sourceType = new DataTable();
                var adapter = new SQLiteDataAdapter
                {
                    SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tSource", conn)
                };
                adapter.Fill(_sourceType);
                var wcol = grWork.Columns["cSourceA"] as DataGridViewComboBoxColumn;
                if (wcol != null)
                {
                    wcol.DataSource = _sourceType;
                }
                var ccol = grCert.Columns["ccSource"] as DataGridViewComboBoxColumn;
                if (ccol != null)
                {
                    ccol.DataSource = _sourceType;
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void WorkTypeSave(out Exception exception)
        {
            exception = null;
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tWorkType (fName) VALUES(:name)";
                const string updCmd = "UPDATE tWorkType SET fName=:name WHERE fId=:id";
                for (var i = 0; i < grDicWork.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("name", DbType.String));
                    if (string.IsNullOrEmpty(grDicWork.Rows[i].Cells["cdwId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grDicWork.Rows[i].Cells["cdwId"].Value;
                    }
                    insCom.Parameters["name"].Value = grDicWork.Rows[i].Cells["cdwName"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                _workType = new DataTable();
                var adapter = new SQLiteDataAdapter
                {
                    SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tWorkType", conn)
                };
                adapter.Fill(_workType);
                var wcol = grWork.Columns["cTypeA"] as DataGridViewComboBoxColumn;
                if (wcol != null)
                {
                    wcol.DataSource = _workType;
                    wcol.ValueMember = "fId";
                    wcol.DisplayMember = "fName";
                }
                var ccol = grCert.Columns["ccType"] as DataGridViewComboBoxColumn;
                if (ccol != null)
                {
                    ccol.DataSource = _workType;
                    ccol.ValueMember = "fId";
                    ccol.DisplayMember = "fName";
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void ConsTypeSave(out Exception exception)
        {
            exception = null;
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tConsType (fName) VALUES(:name)";
                const string updCmd = "UPDATE tConsType SET fName=:name WHERE fId=:id";
                for (var i = 0; i < grDicCons.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("name", DbType.String));
                    if (string.IsNullOrEmpty(grDicCons.Rows[i].Cells["cdcId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grDicCons.Rows[i].Cells["cdcId"].Value;
                    }
                    insCom.Parameters["name"].Value = grDicCons.Rows[i].Cells["cdcName"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                _consType = new DataTable();
                var adapter = new SQLiteDataAdapter
                {
                    SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tConsType", conn)
                };
                adapter.Fill(_consType);
                var ccol = grCons.Columns["csType"] as DataGridViewComboBoxColumn;
                if (ccol != null)
                {
                    ccol.DataSource = _consType;
                    ccol.ValueMember = "fId";
                    ccol.DisplayMember = "fName";
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClientSave(out Exception exception)
        {
            exception = null;
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tClient (fName,fPhone,fEmail,fNote) VALUES(:name,:phone,:mail,:note)";
                const string updCmd = "UPDATE tClient SET fName=:name,fPhone=:phone,fEmail=:mail,fNote=:note WHERE fId=:id";
                for (var i = 0; i < grDicClient.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("name", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("phone", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("mail", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("note", DbType.String));
                    if (string.IsNullOrEmpty(grDicClient.Rows[i].Cells["cdpId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grDicClient.Rows[i].Cells["cdpId"].Value;
                    }
                    insCom.Parameters["name"].Value = grDicClient.Rows[i].Cells["cdpName"].Value.ToString();
                    insCom.Parameters["phone"].Value = grDicClient.Rows[i].Cells["cdpPhone"].Value.ToString();
                    insCom.Parameters["mail"].Value = grDicClient.Rows[i].Cells["cdpMail"].Value.ToString();
                    insCom.Parameters["note"].Value = grDicClient.Rows[i].Cells["cdpNote"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void grCert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if(iRow<0) return;
            var iCol = e.ColumnIndex;
            var fr = new FrClient();
            switch (grCert.Columns[iCol].Name)
            {
                case "ccCons":
                    var frCons = new FrCons();
                    try
                    {
                        frCons.WorkDate = Convert.ToDateTime(grCert.Rows[iRow].Cells["ccDate"].Value);
                    }
                    catch (Exception)
                    {
                        frCons.WorkDate = DateTime.Now;
                    }
                    frCons.WorkId = 0;
                    try
                    {
                        frCons.CertId = Convert.ToInt32(grCert.Rows[iRow].Cells["ccId"].Value);
                        frCons.ConsId = new List<int>();
                    }
                    catch (Exception)
                    {
                        frCons.CertId = 0;
                        frCons.ConsId = new List<int>();
                        foreach (var con in _certCons.Where(c => c.Value == iRow))
                        {
                            frCons.ConsId.Add(con.Key);
                        }
                    }
                    frCons.ShowDialog();
                    if (frCons.Cons == null || !frCons.FrOk) return;

                    if (frCons.CertId == 0)
                    {
                        var remove = _certCons.Where(c => c.Value == iRow).Select(con => con.Key).ToList();
                        foreach (var item in remove)
                        {
                            _certCons.Remove(item);
                        }
                        foreach (var i in frCons.ConsId)
                        {
                            _certCons.Add(i, iRow);
                        }
                    }
                    grCert.Rows[iRow].Cells[iCol].Value = frCons.Cons.Amount;
                    GraphLoad();
                    break;
                case "ccPayerName":
                    fr.ShowDialog();
                    grCert.Rows[iRow].Cells["ccPayerId"].Value = fr.ClientName.Id;
                    grCert.Rows[iRow].Cells["ccPayerName"].Value = fr.ClientName.Name;
                    break;
                case "ccClientName":
                    fr.ShowDialog();
                    grCert.Rows[iRow].Cells["ccClientId"].Value = fr.ClientName.Id;
                    grCert.Rows[iRow].Cells["ccClientName"].Value = fr.ClientName.Name;
                    break;
            }
        }

        private void btCertSave_Click(object sender, EventArgs e)
        {
            SaveCerts();
        }

        private void btDicSave_Click(object sender, EventArgs e)
        {
            Exception exception;
            ClientSave(out exception);
            if (exception == null)
            {
                ConsTypeSave(out exception);
                if (exception == null)
                {
                    SourceSave(out exception);
                    if (exception == null)
                    {
                        WorkTypeSave(out exception);
                    }
                }
            }
            MessageBox.Show(exception == null ? Resources.SaveChange : exception.Message, Resources.Orders,
                MessageBoxButtons.OK);
            DictLoad();
        }

        private void chMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
