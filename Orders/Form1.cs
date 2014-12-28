using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using Orders.Classes;
using Orders.Properties;

namespace Orders
{
    public partial class Form1 : Form
    {
        private DataTable _workType;
        private DataTable _consType;
        private DataTable _sourceType;
        private bool _hasChange;

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
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS \"Id\",W.fClientId AS ClientId,Wt.fId AS \"Type\"," +
                                     "datetime(W.fDate, 'unixepoch') AS \"Date\",W.fPrepay AS \"Prepay\"," +
                                     "W.fExcess AS Excess,W.fCons AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,datetime(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "W.fConsTypeId AS ConsType " +
                                     "FROM tWork W JOIN tClient C ON W.fClientId=C.fId LEFT JOIN tConsType Ct ON W.fConsTypeId=Ct.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "ORDER BY \"Date\",Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);

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

                //lst.Sort((item1,item2)=>DateTime.Compare(item1.Date, item2.Date));
                var mLst = new List<History>();
                var currDate = DateTime.Now;
                for (var i = 1; i <= 12; i++)
                {
                    mLst.Add(new History {Month = i});
                }

                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "cTypeA",
                    DataSource = _workType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Type
                };
                grWork.Columns.Insert((int) TableCol.TypeColIndex, combo);
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "cSourceA",
                    DataSource = _sourceType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Source
                };
                grWork.Columns.Insert((int) TableCol.SourColIndex, combo);

                combo = new DataGridViewComboBoxColumn
                {
                    Name = "cConsA",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.ConsType
                };
                grWork.Columns.Insert((int) TableCol.ConsColIndex, combo);

                const string csCmd = "SELECT fTypeId AS \"Type\",fAmount AS Amount," +
                                     "datetime(fDate, 'unixepoch') AS \"Date\",fComment AS \"Comment\" " +
                                     "FROM tCons " +
                                     "WHERE fDate>=strftime('%s', :start) AND fDate<strftime('%s', :end)";
                var csCom = new SQLiteCommand(csCmd, conn);
                var curr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                csCom.Parameters.AddWithValue("start", curr);
                csCom.Parameters.AddWithValue("end", curr.AddMonths(1));
                csCom.Prepare();
                var csTable = new DataTable();
                var csAdapt = new SQLiteDataAdapter(csCom);
                csAdapt.Fill(csTable);

                // grCons.Columns.Insert(0, combo);
                foreach (DataRow row in csTable.Rows)
                {
                    var cons = new Cons(row);
                    var iRow = grCons.Rows[grCons.RowCount - 2].Cells;
                    iRow["csNumber"].Value = grCons.RowCount - 1;
                    iRow["csType"].Value = cons.Type;
                    iRow["csAmount"].Value = cons.Amount;
                    iRow["csDate"].Value = cons.Date;
                    iRow["csComment"].Value = cons.Comment;
                }

                var date = new CalendarColumn {Name = "cPreDate", HeaderText = Resources.Date, Width = 120};
                grWork.Columns.Insert((int) TableCol.PreDateColIndex, date);

                date = new CalendarColumn {Name = "cExDate", HeaderText = Resources.ExDate, Width = 120};
                grWork.Columns.Insert((int) TableCol.ExDateColIndex, date);
                var inc = 0D;
                var con = 0D;
                var hrs = 0D;
                var yInc = 0D;
                var yCon = 0D;
                var yHrs = 0D;

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
                    iRow["cId"].Value = work.Date;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                    c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType > 0)
                        c.Value = work.ConsType;
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;

                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    iRow["cSert"].Value = work.Sert > 0;
                    iRow["cExDate"].Value = work.ExDate == null
                        ? ""
                        : work.ExDate.Value.ToString("dd.MM.yyyy");

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
                var a = ex;
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
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
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
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                var consData = new DataTable();
                const string selCmd = "SELECT DISTINCT C.fTypeId AS \"csType\",C.fAmount AS \"csAmount\"," +
                                      "datetime(C.fDate, 'unixepoch') AS \"csDate\",C.fComment AS \"csComment\" " +
                                      "FROM tCons C JOIN tConsType T ON C.fTypeId=T.fId " +
                                      "WHERE C.fDate>=strftime('%s', :start) AND C.fDate<strftime('%s', :end) " +
                                      "ORDER BY C.fDate";
                var adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(selCmd, conn)};
                adapter.SelectCommand.Parameters.AddWithValue("start", mStart.AddMonths(-1));
                adapter.SelectCommand.Parameters.AddWithValue("end", mStart.AddMonths(1));
                adapter.SelectCommand.Prepare();
                adapter.Fill(consData);
                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "csType",
                    DataPropertyName = "csType",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.ConsType
                };
                grCons.Columns.Insert(0, combo);
                var date = new CalendarColumn
                {
                    Name = "csDate",
                    DataPropertyName = "csDate",
                    HeaderText = Resources.ExDate,
                    Width = 120
                };
                grCons.Columns.Insert(3, date);
                var bSource = new BindingSource {DataSource = consData};
                grCons.DataSource = bSource;
                
                for (var i = 0; i < grCons.Rows.Count; i++)
                {
                    grCons.Rows[i].Cells["csNumber"].Value = i.ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
            finally
            {
                conn.Close();
            }
        }

        private void CertLoad()
        {
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                var certData = new DataTable();
                const string selCmd = "SELECT DISTINCT S.fId AS \"ccId\"," +
                                      "S.fPayId AS \"ccPayerId\",P.fName AS \"ccPayerName\"," +
                                      "S.fClientId AS \"ccClientId\",C.fName AS \"ccClientName\"," +
                                      "S.fTypeId AS \"ccTypeId\",datetime(S.fDatePay, 'unixepoch') AS \"ccDatePay\"," +
                                      "datetime(S.fDateEnd, 'unixepoch') AS \"ccDateEnd\",S.fPrice AS \"ccPrice\"," +
                                      "S.fHours AS \"ccHours\",S.fSource AS \"ccSource\" " +
                                      "FROM tSert S JOIN tClient P ON S.fPayId=P.fId JOIN tClient C ON S.fClientId=C.fId " +
                                      "WHERE S.fCash=0 ORDER BY S.fDateEnd";
                var adapter = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(selCmd, conn) };
                adapter.Fill(certData);

                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "ccType",
                    DataPropertyName = "ccTypeId",
                    DataSource = _workType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Type
                };
                grCert.Columns.Insert(0, combo);
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "ccSource",
                    DataPropertyName = "ccSource",
                    DataSource = _sourceType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.Source
                };
                grCert.Columns.Insert(0, combo);
                var date = new CalendarColumn
                {
                    Name = "ccDatePay",
                    DataPropertyName = "ccDatePay",
                    HeaderText = Resources.DatePay,
                    Width = 120
                };
                grCert.Columns.Insert(3, date);

                date = new CalendarColumn
                {
                    Name = "ccDateEnd",
                    DataPropertyName = "ccDateEnd",
                    HeaderText = Resources.DateEnd,
                    Width = 120
                };
                grCert.Columns.Insert(3, date);
                var bSource = new BindingSource { DataSource = certData };
                grCert.DataSource = bSource;

                for (var i = 0; i < grCert.Rows.Count; i++)
                {
                    grCert.Rows[i].Cells["csNumber"].Value = i.ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkLoad();
            GraphLoad();
            ConsLoad();
            CertLoad();
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

        private void grWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var cell = sender as DataGridViewCell;
            //if (cell!=typeof(DataGridViewCheckBoxCell)) return;
            var iRow = e.RowIndex;
            var iCol = e.ColumnIndex;
            switch (iCol)
            {
                case (int) TableCol.SertColIndex:
                {

                    if (grWork.Rows[iRow].Cells[iCol].Value != null && (bool) grWork.Rows[iRow].Cells[iCol].Value)
                        grWork.Rows[iRow].Cells[iCol].Value = false;
                    else
                    {
                        grWork.Rows[iRow].Cells[iCol].Value = true;
                        MessageBox.Show(Resources.Future, Resources.Orders,
                            MessageBoxButtons.OK);
                    }
                }
                    break;
                case (int) TableCol.NameColIndex:
                    return;
                    /*var fr = new FrClient();
                    fr.ShowDialog();
                    grWork.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                    grWork.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    break;*/
            }
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
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS \"Id\",W.fClientId AS ClientId,Wt.fId AS \"Type\"," +
                                     "datetime(W.fDate, 'unixepoch') AS \"Date\",W.fPrepay AS \"Prepay\"," +
                                     "W.fExcess AS Excess,W.fCons AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,datetime(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "W.fConsTypeId AS ConsType " +
                                     "FROM tWork W JOIN tClient C ON W.fClientId=C.fId LEFT JOIN tConsType Ct ON W.fConsTypeId=Ct.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end)" +
                                     "ORDER BY \"Date\",Client";
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
                    iRow["cId"].Value = work.Date;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                    c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType > 0)
                        c.Value = work.ConsType;
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;

                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    iRow["cSert"].Value = work.Sert > 0;
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
            var iCol = e.ColumnIndex;
            switch (iCol)
            {
                case (int) TableCol.SertColIndex:
                {

                    if (grWork.Rows[iRow].Cells[iCol].Value != null && (bool) grWork.Rows[iRow].Cells[iCol].Value)
                        grWork.Rows[iRow].Cells[iCol].Value = false;
                    else
                    {
                        grWork.Rows[iRow].Cells[iCol].Value = true;
                        MessageBox.Show(Resources.Future, Resources.Orders,
                            MessageBoxButtons.OK);
                    }
                }
                    break;
                case (int) TableCol.NameColIndex:
                    var fr = new FrClient();
                    fr.ShowDialog();
                    grWork.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                    grWork.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    break;
            }
        }

        private void SaveChanges()
        {
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tWork (fClientId,fTypeId,fDate," +
                                      "fPrepay,fExcess,fExcessDate,fConsTypeId,fCons,fHours," +
                                      "fSourceId,fSertId) VALUES(:client,:type," +
                                      "strftime('%s', :date),:prepay,:excess," +
                                      "CASE WHEN :excess<1 THEN NULL ELSE strftime('%s', :exdate) END," +
                                      ":constype,:cons,:hour,:source," +
                                      "CASE WHEN :sert=0 THEN NULL ELSE :sert END)";
                var insCom = new SQLiteCommand(insCmd, conn);
                insCom.Parameters.AddWithValue("client", 1);
                insCom.Parameters.AddWithValue("type", 1);
                insCom.Parameters.Add(new SQLiteParameter("date", DbType.DateTime));
                insCom.Parameters.Add(new SQLiteParameter("prepay", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("excess", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("exdate", DbType.DateTime));
                insCom.Parameters.Add(new SQLiteParameter("constype", DbType.Int32));
                insCom.Parameters.Add(new SQLiteParameter("cons", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("hour", DbType.Double));
                insCom.Parameters.AddWithValue("source", 1);
                insCom.Parameters.AddWithValue("sert", 0);
                for (var i = 0; i < grWork.RowCount - 1; i++)
                {
                    //var a = grWork.Rows[i].Cells["cTypeA"].Value;
                    if (grWork.Rows[i].Cells["cId"].Value != null) continue;
                    insCom.Parameters["date"].Value = DateTime.Parse(grWork.Rows[i].Cells["cPreDate"].Value.ToString());
                    insCom.Parameters["prepay"].Value = grWork.Rows[i].Cells["cPrepay"].Value;
                    insCom.Parameters["excess"].Value = grWork.Rows[i].Cells["cExcess"].Value;
                    insCom.Parameters["exdate"].Value =
                        string.IsNullOrEmpty(grWork.Rows[i].Cells["cExcess"].Value.ToString())
                            ? DateTime.Now
                            : DateTime.Parse(grWork.Rows[i].Cells["cExDate"].Value.ToString());
                    insCom.Parameters["constype"].Value =
                        string.IsNullOrEmpty(grWork.Rows[i].Cells["cExcess"].Value.ToString()) ||
                        Convert.ToDouble(grWork.Rows[i].Cells["cExcess"].Value) < 0.01
                            ? 0
                            : grWork.Rows[i].Cells["cConsA"].Value;
                    insCom.Parameters["cons"].Value = grWork.Rows[i].Cells["cCons"].Value;
                    insCom.Parameters["hour"].Value = grWork.Rows[i].Cells["cHours"].Value;
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                _hasChange = false;
                GraphLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Error, MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SaveCons()
        {
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
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
                MessageBox.Show(ex.Message, Resources.Error, MessageBoxButtons.OK);
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
            chMonth.Width = tabGraph.Width/2 - 5;
            chYear.Width = tabGraph.Width/2 - 5;
        }

        private void btConsSave_Click(object sender, EventArgs e)
        {
            SaveCons();
        }
    }
}
