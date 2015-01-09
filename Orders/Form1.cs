using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            TypeColIndex = 3,
            NameColIndex = 4,
            PreDateColIndex = 6,
            ExDateColIndex = 9,
            ConsColIndex = 8,
            SourColIndex = 11,
            SertColIndex = 15,
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
                                     "date(W.fDate, 'unixepoch') AS Date,W.fPrepay AS Prepay," +
                                     "W.fExcess AS Excess,SUM(Cs.fAmount) AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,date(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "P.fName AS PayerName " +
                                     "FROM tWork W " +
                                     "JOIN tClient C ON W.fClientId=C.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId " +
                                     "JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "LEFT JOIN tSert Sr ON Sr.fId=W.fSertId " +
                                     "LEFT JOIN tClient P ON Sr.fPayId=P.fId " +
                                     "LEFT JOIN tCons Cs ON Cs.fWorkId=W.fId " +
                                     "LEFT JOIN tConsType Ct ON Cs.fTypeId=Ct.fId AND Ct.fType=0 " +
                                     "GROUP BY Id,ClientId,Type,Date,Prepay,Excess,Hours,Source,Sert,Client,ExDate," +
                                     "PayerName ORDER BY Date,Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                
                var mLst = new List<History>();
                var currDate = DateTime.Now;
                for (var i = 1; i <= 12; i++)
                {
                    mLst.Add(new History {Month = i});
                }
                
                var inc = 0D;
                var con = 0D;
                var hrs = 0D;
                var yInc = 0D;
                var yCon = 0D;
                var yHrs = 0D;

                grWork.RowCount = 1;
                foreach (DataRow row in wkTable.Rows)
                {
                    var work = new Work(row);
                    foreach (var history in mLst)
                    {
                        if (history.Month == work.Date.Month && work.Date.Year == currDate.Year)
                        {
                            history.CIncome += work.Prepay + work.Excess;
                            break;
                        }
                        if (history.Month != work.Date.Month || work.Date.Year != currDate.Year - 1) continue;
                        history.LIncome += work.Prepay + work.Excess;
                        break;
                    }

                    if (work.Date.Year != currDate.Year) continue;
                    yInc += work.Prepay + work.Excess;
                    yCon += work.Cons;
                    yHrs += work.Hours;

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

                    inc += work.Prepay + work.Excess;
                    con += work.Cons;
                    hrs += work.Hours;
                }


                lMonthC.Text = currDate.ToString("MMMM");

                lIncomeC.Text = inc.ToString("C0");
                lConsC.Text = con.ToString("C0");
                lProfitC.Text = (inc - con).ToString("C0");
                lHoursC.Text = hrs.ToString("N0");

                lIncomeY.Text = yInc.ToString("C0");
                lConsY.Text = yCon.ToString("C0");
                lProfitY.Text = (yInc - yCon).ToString("C0");
                lHoursY.Text = yHrs.ToString("N0");
                lIncomeYA.Text = (yInc/currDate.Month).ToString("C0");

                lYearC.Text = currDate.Year.ToString("D");
                lYearL.Text = (currDate.Year - 1).ToString("D");
                lSumCAll.Text = mLst.Sum(m => m.CIncome).ToString("C0");
                lSumLAll.Text = mLst.Sum(m => m.LIncome).ToString("C0");
                foreach (var history in mLst)
                {
                    Controls.Find("lSumC" + history.Month, true)[0].Text = history.CIncome.ToString("C0");
                    Controls.Find("lSumL" + history.Month, true)[0].Text = history.LIncome.ToString("C0");
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
                    "SELECT DISTINCT T.fName AS \"Type\",COUNT(W.fId) AS \"Count\",SUM((fPrepay+fExcess)/1000) AS \"Income\" " +
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
                var date = new CalendarColumn {Name = "cPreDate", HeaderText = Resources.Date, Width = 120};
                grWork.Columns.Insert((int) TableCol.PreDateColIndex, date);

                date = new CalendarColumn {Name = "cExDate", HeaderText = Resources.ExDate, Width = 120};
                grWork.Columns.Insert((int) TableCol.ExDateColIndex, date);

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
                grCert.Columns.Insert(1, combo);

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
                grCert.Columns.Insert(1, combo);

                date = new CalendarColumn
                {
                    Name = "ccDatePay",
                    DataPropertyName = "ccDatePay",
                    HeaderText = Resources.DatePay,
                    Width = 120
                };
                grCert.Columns.Insert(6, date);

                date = new CalendarColumn
                {
                    Name = "ccDateEnd",
                    DataPropertyName = "ccDateEnd",
                    HeaderText = Resources.DateEnd,
                    Width = 120
                };
                grCert.Columns.Insert(7, date);

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
                    HeaderText = Resources.ExDate,
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlLoad();
            WorkLoad();
            GraphLoad();
            ConsLoad();
            CertLoad();
            DictLoad();
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
                                     "date(W.fDate, 'unixepoch') AS Date,W.fPrepay AS Prepay," +
                                     "W.fExcess AS Excess,SUM(Cs.fAmount) AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,date(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "P.fName AS PayerName " +
                                     "FROM tWork W " +
                                     "JOIN tClient C ON W.fClientId=C.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId " +
                                     "JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "LEFT JOIN tSert Sr ON Sr.fId=W.fSertId " +
                                     "LEFT JOIN tClient P ON Sr.fPayId=P.fId " +
                                     "LEFT JOIN tCons Cs ON Cs.fWorkId=W.fId " +
                                     "LEFT JOIN tConsType Ct ON Cs.fTypeId=Ct.fId AND Ct.fType=0 " +
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
                lIncomeC.Text = inc.ToString("C0");
                lConsC.Text = con.ToString("C0");
                lProfitC.Text = (inc - con).ToString("C0");
                lHoursC.Text = hrs.ToString("N0");
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
                    if (frCons.Cons == null || !frCons.frOk) return;

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
                 for (var i = 0; i < grWork.RowCount - 1; i++)
                {
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
                    if (grWork.Rows[i].Cells["cId"].Value == null)
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grWork.Rows[i].Cells["cId"].Value;
                    }
                    insCom.Parameters["client"].Value = Convert.ToInt32(grWork.Rows[i].Cells["cClientId"].Value);
                    insCom.Parameters["type"].Value = Convert.ToInt32(grWork.Rows[i].Cells["cTypeA"].Value);
                    insCom.Parameters["source"].Value = Convert.ToInt32(grWork.Rows[i].Cells["cSourceA"].Value);
                    insCom.Parameters["sert"].Value = Convert.ToInt32(grWork.Rows[i].Cells["cCertId"].Value);
                    insCom.Parameters["date"].Value =
                        DateTime.Parse(grWork.Rows[i].Cells["cPreDate"].Value.ToString());
                    insCom.Parameters["prepay"].Value = grWork.Rows[i].Cells["cPrepay"].Value;
                    insCom.Parameters["excess"].Value = grWork.Rows[i].Cells["cExcess"].Value == null ||
                                                        string.IsNullOrEmpty(
                                                            grWork.Rows[i].Cells["cExcess"].Value.ToString()) ||
                                                        Convert.ToDouble(grWork.Rows[i].Cells["cExcess"].Value) < 0.01
                        ? 0
                        : grWork.Rows[i].Cells["cExcess"].Value;
                    insCom.Parameters["exdate"].Value =
                        grWork.Rows[i].Cells["cExcess"].Value == null ||
                        string.IsNullOrEmpty(grWork.Rows[i].Cells["cExcess"].Value.ToString()) ||
                        Convert.ToDouble(grWork.Rows[i].Cells["cExcess"].Value) < 0.01
                            ? DateTime.Now
                            : DateTime.Parse(grWork.Rows[i].Cells["cExDate"].Value.ToString());
                    insCom.Parameters["hour"].Value = grWork.Rows[i].Cells["cHours"].Value;
                    insCom.Prepare();
                    var insDr = insCom.ExecuteReader();
                    while (insDr.Read())
                    {
                        var id = Convert.ToInt32(insDr[0]);
                        var remove = new List<int>();
                        foreach (var con in _workCons.Where(c => c.Value == i))
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
                    }
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                _hasChange = false;
                GraphLoad();
                WorkLoad();
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
                        foreach (var con in _certCons.Where(c => c.Value == i))
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
                var insCom = new SQLiteCommand(insCmd, conn);
                insCom.Parameters.Add(new SQLiteParameter("type", DbType.Int32));
                insCom.Parameters.Add(new SQLiteParameter("amount", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("date", DbType.Int32));
                insCom.Parameters.Add(new SQLiteParameter("comment", DbType.AnsiString));
                for (var i = 0; i < grWork.RowCount - 1; i++)
                {
                    if (grCons.Rows[i].Cells["csNumber"].Value != null) continue;
                    insCom.Parameters["date"].Value = DateTime.Parse(grCons.Rows[i].Cells["csDate"].Value.ToString());
                    insCom.Parameters["type"].Value = grCons.Rows[i].Cells["csType"].Value;
                    insCom.Parameters["amount"].Value = grCons.Rows[i].Cells["csAmount"].Value;
                    insCom.Parameters["comment"].Value = DateTime.Parse(grWork.Rows[i].Cells["csComment"].Value.ToString());
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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

        private void Form1_Resize(object sender, EventArgs e)
        {
           /* chMonth.Width = tabGraph.Width/2 - 5;
            chYear.Width = tabGraph.Width/2 - 5;*/
        }

        private void btConsSave_Click(object sender, EventArgs e)
        {
            SaveCons();
        }
        
        private void btDicClientSave_Click(object sender, EventArgs e)
        {
            ClientSave();
        }

        private void btDicSourceSave_Click(object sender, EventArgs e)
        {
            SourceSave();
        }

        private void SourceSave()
        {
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
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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

        private void btDicWorkSave_Click(object sender, EventArgs e)
        {
            WorkTypeSave();
        }

        private void WorkTypeSave()
        {
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
                
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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
                var ccol = grWork.Columns["ccType"] as DataGridViewComboBoxColumn;
                if (ccol != null)
                {
                    ccol.DataSource = _workType;
                    ccol.ValueMember = "fId";
                    ccol.DisplayMember = "fName";
                }
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

        private void btDicConsSave_Click(object sender, EventArgs e)
        {
            ConsTypeSave();
        }

        private void ConsTypeSave()
        {
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
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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

        private void ClientSave()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tClient (fName,fPhone,fEmail,fNote) VALUES(:name,:phone,:mail,:note)";
                const string updCmd = "UPDATE tConsType SET fName=:name,fPhone=:phone,fEmail=:mail,fNote=:note WHERE fId=:id";
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
                        insCom.Parameters["id"].Value = grDicClient.Rows[i].Cells["cdcId"].Value;
                    }
                    insCom.Parameters["name"].Value = grDicClient.Rows[i].Cells["cdpName"].Value.ToString();
                    insCom.Parameters["phone"].Value = grDicClient.Rows[i].Cells["cdpPhone"].Value.ToString();
                    insCom.Parameters["mail"].Value = grDicClient.Rows[i].Cells["cdpMail"].Value.ToString();
                    insCom.Parameters["note"].Value = grDicClient.Rows[i].Cells["cdpNote"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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
                    if (frCons.Cons == null || !frCons.frOk) return;

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
    }
}
