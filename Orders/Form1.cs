using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Properties;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using Button = System.Windows.Forms.Button;

namespace Orders
{
    public partial class Form1 : Form
    {
        #region Поля класса

        private bool _hasChange;
        private readonly Dictionary<int, int> _workCons = new Dictionary<int, int>();
        private readonly List<ECons> _workConses = new List<ECons>();
        private readonly List<ECert> _workCerts = new List<ECert>();
        private DateTime _currentDate = DateTime.Now;
        private readonly List<int> _deleteWorkList = new List<int>();
        private readonly List<int> _deleteConsList = new List<int>();

        #endregion

        #region Управление формой

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["OrderContext"].ConnectionString;
                var conn = new SQLiteConnection(connStr);
                try
                {
                    conn.Open();
                    const string cmd = "SELECT COUNT(*) FROM \"tWork\"";
                    var com = new SQLiteCommand(cmd, conn);
                    com.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    var com = new SQLiteCommand("CREATE TABLE \"tClient\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                                "NOT NULL,\"fName\" TEXT NOT NULL,\"fPhone\" TEXT,\"fEmail\" TEXT," +
                                                "\"fNote\" TEXT,\"fDate\" INTEGER NOT NULL DEFAULT 0);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tCons\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                            "NOT NULL,\"fTypeId\" INTEGER NOT NULL,\"fAmount\" REAL NOT NULL " +
                                            "DEFAULT 0,\"fDate\" INTEGER NOT NULL,\"fComment\" TEXT,\"fCertCons\" " +
                                            "INTEGER NOT NULL DEFAULT 0,\"fWorkId\" INTEGER,\"fCertId\" INTEGER," +
                                            "CONSTRAINT \"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES \"tConsType\" " +
                                            "(\"fId\") ON UPDATE RESTRICT);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tConsType\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                            "NOT NULL,\"fName\" TEXT NOT NULL,\"fCertCons\" INTEGER NOT NULL DEFAULT " +
                                            "0);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tError\" (\"fDate\" INTEGER NOT NULL,\"fError\" TEXT NOT " +
                                            "NULL,\"fFunc\"  TEXT);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tSource\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT " +
                                            "NULL,\"fName\"  TEXT NOT NULL);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tWorkType\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT " +
                                            "NULL,\"fName\" TEXT NOT NULL);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tSert\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                                            "\"fPayId\" INTEGER NOT NULL,\"fClientId\" INTEGER NOT NULL,\"fTypeId\" " +
                                            "INTEGER NOT NULL,\"fDatePay\" INTEGER NOT NULL,\"fDateEnd\" INTEGER NOT NULL," +
                                            "\"fPrice\" REAL NOT NULL DEFAULT 0,\"fHours\" REAL NOT NULL DEFAULT 0,\"fCash\" " +
                                            "INTEGER NOT NULL DEFAULT 0,\"fSource\" INTEGER NOT NULL,\"fConsed\" REAL NOT " +
                                            "NULL DEFAULT 0,CONSTRAINT \"Sourse\" FOREIGN KEY (\"fSource\") REFERENCES " +
                                            "\"tSource\" (\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Client\" FOREIGN KEY " +
                                            "(\"fClientId\") REFERENCES \"tClient\" (\"fId\") ON UPDATE RESTRICT,CONSTRAINT " +
                                            "\"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES \"tWorkType\" (\"fId\") ON UPDATE " +
                                            "RESTRICT,CONSTRAINT \"Payer\" FOREIGN KEY (\"fPayId\") REFERENCES \"tClient\" " +
                                            "(\"fId\") ON UPDATE RESTRICT);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tWork\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                                            "\"fClientId\" INTEGER NOT NULL,\"fTypeId\" INTEGER NOT NULL,\"fDate\" INTEGER " +
                                            "NOT NULL,\"fPrepay\" REAL NOT NULL DEFAULT 0,\"fExcess\" REAL NOT NULL DEFAULT 0," +
                                            "\"fHours\" REAL NOT NULL DEFAULT 0,\"fSourceId\" INTEGER NOT NULL,\"fSertId\" " +
                                            "INTEGER,\"fExcessDate\" INTEGER,\"fDuty\" REAL NOT NULL DEFAULT 0,CONSTRAINT " +
                                            "\"Client\" FOREIGN KEY (\"fClientId\") REFERENCES \"tClient\" (\"fId\") ON UPDATE " +
                                            "RESTRICT,CONSTRAINT \"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES \"tWorkType\" " +
                                            "(\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Source\" FOREIGN KEY (\"fSourceId\") " +
                                            "REFERENCES \"tSource\" (\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Sert\" " +
                                            "FOREIGN KEY (\"fSertId\") REFERENCES \"tSert\" (\"fId\") ON UPDATE RESTRICT);", conn);
                    com.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }

                _currentDate = DateTime.Now;
                GridMonthLoad(_currentDate);
                GetClients();
                LoadCerts();
                LoadDuty();
                var minDate = WorkLib.GetMinDate();
                if (minDate == null) return;
                for (var i = minDate.Value.Year; i <= DateTime.Now.Year; i++)
                {
                    cbArchYear.Items.Add(i);
                }

                var fr = new FrEvents();
                if (fr.ItemCount > 0)
                {
                    fr.Top = Top + ClientSize.Height - fr.Height;
                    fr.Left = Left + ClientSize.Width - fr.Width;
                    fr.Show();
                }
                else
                {
                    fr.Close();
                }
                LoadErrors();
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception, cName + "/" + mName);
                }
            }
            _hasChange = false;
        }
        
        private void btHome_Click(object sender, EventArgs e)
        {
            _currentDate = DateTime.Now;
            GridMonthLoad(_currentDate);
            CertGraph();
        }    
        private void Form1_Move(object sender, EventArgs e)
        {
            foreach (var control in Application.OpenForms)
            {
                if (typeof(FrEvents) != control.GetType()) continue;
                var fr = (control as FrEvents);
                if (fr == null) continue;
                fr.Top = Top + ClientSize.Height - fr.Height;
                fr.Left = Left + ClientSize.Width - fr.Width;
                fr.Show();
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

        #endregion

        #region Вкладка Работы

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
            _hasChange = false;
            var button = sender as Button;
            if (button == null) return;
            _currentDate = new DateTime(_currentDate.Year, Convert.ToInt32(button.Tag), 1);
            GridMonthLoad(_currentDate);
            LoadCerts();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void grWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grWork.Columns[iCol].Name)
            {
                case "cwCons":
                    using (var frCons = new FrCons())
                    {
                        frCons.Conses = _workConses.Where(r => r.RowId == iRow).ToList();
                        try
                        {
                            frCons.WorkId = Convert.ToInt32(grWork.Rows[iRow].Cells["cwId"].Value);
                            frCons.ConsId = new List<int>();
                        }
                        catch (Exception)
                        {
                            frCons.WorkId = 0;
                            frCons.ConsId = new List<int>();
                            foreach (var con in _workCons.Where(c => c.Value == iRow))
                            {
                                frCons.ConsId.Add(con.Key);
                            }
                        }
                        frCons.ShowDialog();
                        if (frCons.Conses == null || !frCons.FrOk) return;
                        _hasChange = true;
                        var conses = frCons.Conses;
                        _workConses.RemoveAll(r => r.RowId == iRow);
                        foreach (var cons in conses)
                        {
                            cons.RowId = iRow;
                        }
                        _workConses.AddRange(conses);

                        foreach (var i in frCons.DeleteConsList.Where(i => !_deleteConsList.Contains(i)))
                        {
                            _deleteConsList.Add(i);
                        }

                        grWork.Rows[iRow].Cells[iCol].Value = frCons.Conses.Sum(r => r.Amount);
                    }
                    break;
                case "cwClient":
                    var fr = new FrClient();
                    string cwName;
                    try
                    {
                        cwName = grWork.Rows[iRow].Cells["cwClient"].Value.ToString();
                    }
                    catch
                    {
                        cwName = "";
                    }
                    fr.ClientName = new EClient { Name = cwName };
                    fr.ShowDialog();
                    try
                    {
                        if (fr.ClientName != null && fr.ClientName.Id > 0)
                        {
                            grWork.Rows[iRow].Cells["cwClientId"].Value = fr.ClientName.Id;
                            grWork.Rows[iRow].Cells["cwClient"].Value = fr.ClientName.Name;
                        }
                    }
                    catch (Exception exception)
                    {
                        var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                        if (declaringType != null)
                        {
                            var cName = declaringType.Name;
                            var mName = MethodBase.GetCurrentMethod().Name;
                            Errors.SaveError(exception, cName + "/" + mName);
                        }
                    }
                    break;
                case "cwType":
                    var frWType = new FrWorkType();
                    string twName;
                    try
                    {
                        twName = grWork.Rows[iRow].Cells["cwType"].Value.ToString();
                    }
                    catch
                    {
                        twName = "";
                    }
                    frWType.WorkType = new EWorkType { Name = twName };
                    frWType.ShowDialog();
                    if (frWType.WorkType != null && frWType.WorkType.Id>0)
                    {
                        grWork.Rows[iRow].Cells["cwTypeId"].Value = frWType.WorkType.Id;
                        grWork.Rows[iRow].Cells["cwType"].Value = frWType.WorkType.Name;
                    }
                    break;
                case "cwSource":
                    var frSource = new FrSource();
                    string swName;
                    try
                    {
                        swName = grWork.Rows[iRow].Cells["cwSource"].Value.ToString();
                    }
                    catch
                    {
                        swName = "";
                    }
                    frSource.Source = new ESourceType { Name = swName };
                    frSource.ShowDialog();
                    if (frSource.Source != null&&frSource.Source.Id>0)
                    {
                        grWork.Rows[iRow].Cells["cwSourceId"].Value = frSource.Source.Id;
                        grWork.Rows[iRow].Cells["cwSource"].Value = frSource.Source.Name;
                    }
                    break;
                case "cwDelete":
                    var res = MessageBox.Show(Resources.DeleteRecord, Resources.Orders, MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            var id = Convert.ToInt32(grWork.Rows[iRow].Cells["cwId"].Value);
                            _deleteWorkList.Add(id);
                        }
                        catch
                        {

                        }
                        try
                        {
                            grWork.Rows.RemoveAt(iRow);
                            _workConses.RemoveAll(r => r.RowId == iRow);
                            foreach (var cons in _workConses.Where(r => r.RowId > iRow))
                            {
                                cons.RowId = cons.RowId - 1;
                            }
                            _workCerts.RemoveAll(r=>r.RowId==iRow);
                            foreach (var cert in _workCerts)
                            {
                                cert.RowId = cert.RowId - 1;
                            }
                            _hasChange = true;
                        }
                        catch (InvalidOperationException) { }
                    }
                    break;
            }
        }
        private void grWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grWork.Columns[iCol].Name)
            {
                case "cwCert":
                    var ch = (grWork.Rows[iRow].Cells[iCol] as DataGridViewCheckBoxCell);
                    if (ch != null)
                    {
                        var chVal = Convert.ToBoolean(ch.EditingCellFormattedValue);
                        if (chVal)
                        {
                            var fr = new FrCerts();

                            var row = grWork.Rows[iRow];
                            int certId;
                            int certPayer;
                            int certType;
                            int certSource;
                            double certPrice;
                            double certHours;
                            DateTime certDatePay;
                            try
                            {
                                certId = Convert.ToInt32(row.Cells["cwCertId"].Value);
                            }
                            catch
                            {
                                certId = 0;
                            }
                            try
                            {
                                certPayer = Convert.ToInt32(row.Cells["cwClientId"].Value);
                            }
                            catch
                            {
                                certPayer = 0;
                            }
                            try
                            {
                                certType = Convert.ToInt32(row.Cells["cwTypeId"].Value);
                            }
                            catch
                            {
                                certType = 0;
                            }
                            try
                            {
                                certSource = Convert.ToInt32(row.Cells["cwSourceId"].Value);
                            }
                            catch
                            {
                                certSource = 0;
                            }
                            try
                            {
                                var price = row.Cells["cwPrepay"].Value.ToString().Trim();
                                price = Regex.Replace(price, " +", "");
                                price = price.Replace(".", ",");
                                certPrice = Convert.ToDouble(price);
                            }
                            catch
                            {
                                certPrice = 0;
                            }
                            try
                            {
                                var hours = row.Cells["cwHours"].Value.ToString().Trim();
                                hours = Regex.Replace(hours, " +", "");
                                hours = hours.Replace(".", ",");
                                certHours = Convert.ToDouble(hours);
                            }
                            catch
                            {
                                certHours = 0;
                            }
                            try
                            {
                                var dateP = row.Cells["cwDatePay"].Value.ToString().Trim();
                                certDatePay = Convert.ToDateTime(dateP);
                            }
                            catch
                            {
                                certDatePay = DateTime.Now;
                            }
                            fr.Cert = new ECert
                            {
                                Id = certId,
                                Hours = certHours,
                                PayId = certPayer,
                                Price = certPrice,
                                SourceId = certSource,
                                TypeId = certType,
                                DatePay = certDatePay
                            };
                            fr.ShowDialog();
                            if (fr.Cert != null)
                            {
                                _workCerts.RemoveAll(r => r.RowId == iRow);
                                var cert = fr.Cert;
                                cert.RowId = iRow;
                                _workCerts.Add(cert);
                                var work = new EWork();
                                using (var db = new OrderContext())
                                {
                                    work.ClientId = fr.Cert.PayId;
                                    work.Client = db.Clients.Find(fr.Cert.PayId);
                                    work.DatePay = fr.Cert.DatePay;
                                    work.Hours = fr.Cert.Hours;
                                    work.Prepay = fr.Cert.Price;
                                    work.SourceId = fr.Cert.SourceId;
                                    work.Source = db.SourceTypes.Find(fr.Cert.SourceId);
                                    work.TypeId = fr.Cert.TypeId;
                                    work.Type = db.WorkTypes.Find(fr.Cert.TypeId);
                                }
                                grWork.Rows[iRow].Cells["cwClientId"].Value = work.ClientId;
                                grWork.Rows[iRow].Cells["cwClient"].Value = work.With(r => r.Client)
                                    .Return(r => r.Name, "");
                                grWork.Rows[iRow].Cells["cwTypeId"].Value = work.TypeId;
                                grWork.Rows[iRow].Cells["cwType"].Value = work.With(r => r.Type).Return(r => r.Name, "");
                                grWork.Rows[iRow].Cells["cwDatePay"].Value = work.DatePay.ToString("dd.MM.yyyy");
                                grWork.Rows[iRow].Cells["cwPrepay"].Value = work.Prepay;
                                grWork.Rows[iRow].Cells["cwExcess"].Value = work.Return(r => r.Excess, 0);
                                grWork.Rows[iRow].Cells["cwDateExcess"].Value = work.Return(
                                    r => r.DateExcess != null ? r.DateExcess.Value.ToString("dd.MM.yyyy") : "", "");
                                grWork.Rows[iRow].Cells["cwCons"].Value = work.Cons;
                                grWork.Rows[iRow].Cells["cwHours"].Value = work.Hours;
                                grWork.Rows[iRow].Cells["cwSourceId"].Value = work.SourceId;
                                grWork.Rows[iRow].Cells["cwSource"].Value = work.With(r => r.Source)
                                    .Return(r => r.Name, "");
                            }
                            else
                            {
                                ch.EditingCellFormattedValue = false;
                            }
                        }
                        else
                        {
                            _workCerts.RemoveAll(r => r.RowId == iRow);
                        }
                    }
                    break;
            }

        }
        private void grWork_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;           
        }

        private void GridMonthLoad(DateTime date)
        {
            // список всех работ за месяц
            var monthWorkLst = WorkLib.GetMonthWorks(date).ToList();
            // сумма доходов за месяц
            var monthIncome = monthWorkLst.Sum(r => r.Return(l => l.Prepay, 0) + r.Return(l => l.Excess, 0));
            // сумма расходов за месяц
            var monthConsLst = WorkLib.GetMonthConses(date).ToList();
            WorkLoad(monthWorkLst);
            ConsLoad(monthConsLst);
            var monthCons = monthConsLst.Sum(r => r.Return(l => l.Amount, 0));
            // сумма часов за месяц
            var monthHours = monthWorkLst.Sum(r => r.Return(l => l.Hours, 0));
            // сумма доходов за год
            var yearWorkLst = WorkLib.GetYearWorks(date).ToList();
            var yearIncome = yearWorkLst.Sum(r => r.Return(l => l.Prepay, 0) + r.Return(l => l.Excess, 0));
            // сумма расходов за год
            var yearConsList = WorkLib.GetYearConses(date).ToList();
            var yearCons = yearConsList.Sum(r => r.Return(l => l.Amount, 0));
            // сумма часов за год
            var yearHours = yearWorkLst.Sum(r => r.Hours);
            // средний доход за год
            var monthCount = DateTime.Now.Year == date.Year ? DateTime.Now.Month : 12;
            var yearAvgIncome = yearIncome / monthCount;
            // доходы по месяцам за текущий год
            var currYearIncLst = new List<double>();
            for (var i = 1; i <= 12; i++)
            {
                var dateStart = new DateTime(date.Year, i, 1);
                var workStart = new EWork { DatePay = dateStart };
                var workEnd = new EWork { DatePay = dateStart.AddMonths(1) };
                double sum;
                try
                {
                    sum = yearWorkLst.Where(
                        r => r.datePay >= workStart.datePay && r.datePay < workEnd.datePay)
                        .Sum(r => r.Return(l => l.Prepay, 0) + r.Return(l => l.Excess, 0));
                }
                catch
                {
                    sum = 0;
                }
                currYearIncLst.Add(sum);
                Controls.Find("lSumC" + i, true)[0].Text = sum.ToString("### ### ##0");
            }

            // доходы по месяцам за прошлый год
            var pastYearWorkLst = WorkLib.GetYearWorks(date.AddYears(-1)).ToList();
            var pastYearIncLst = new List<double>();
            for (var i = 1; i <= 12; i++)
            {

                var dateStart = new DateTime(date.Year - 1, i, 1);
                var workStart = new EWork { DatePay = dateStart };
                var workEnd = new EWork { DatePay = dateStart.AddMonths(1) };
                double sum;
                try
                {
                    sum = pastYearWorkLst.Where(
                        r => r.datePay >= workStart.datePay && r.datePay < workEnd.datePay)
                        .Sum(r => r.Return(l => l.Prepay, 0) + r.Return(l => l.Excess, 0));
                }
                catch
                {
                    sum = 0;
                }
                pastYearIncLst.Add(sum);
                Controls.Find("lSumL" + i, true)[0].Text = sum.ToString("### ### ##0");
            }
            // сумма доходов за прошлый год
            var pastYearSum = pastYearIncLst.Sum();
            lConsC.Text = monthCons.ToString("# ### ##0");
            lConsY.Text = yearCons.ToString("# ### ##0");
            lHoursC.Text = monthHours.ToString("N0");
            lHoursY.Text = yearHours.ToString("N0");
            lIncomeC.Text = monthIncome.ToString("# ### ##0");
            lIncomeY.Text = yearIncome.ToString("# ### ##0");
            lProfitC.Text = (monthIncome - monthCons).ToString("# ### ##0");
            lProfitY.Text = (yearIncome - yearCons).ToString("# ### ##0");
            lIncomeYA.Text = yearAvgIncome.ToString("# ### ##0");
            lSumCAll.Text = yearIncome.ToString("# ### ##0");
            lSumLAll.Text = pastYearSum.ToString("# ### ##0");
            lYearC.Text = date.ToString("yyyy");
            lYearL.Text = date.AddYears(-1).ToString("yyyy");
            lMonthC.Text = date.ToString("MMMM");

            Text = string.Format("Обсчёт заказов ({0:MMMM yyyy})", _currentDate);

            #region Графики

            var incSumDic = new Dictionary<string, double>();
            var incCountDic = new Dictionary<string, double>();
            var sourceSumDic = new Dictionary<string, double>();
            var sourceCountDic = new Dictionary<string, double>();
            foreach (var work in monthWorkLst)
            {
                if (incSumDic.ContainsKey(work.Type.Name))
                {
                    incSumDic[work.Type.Name] += (work.Prepay + work.Excess);
                }
                else
                {
                    incSumDic.Add(work.Type.Name, work.Prepay + work.Excess);
                }
                if (incCountDic.ContainsKey(work.Type.Name))
                {
                    incCountDic[work.Type.Name] += 1;
                }
                else
                {
                    incCountDic.Add(work.Type.Name, 1);
                }

                if (sourceSumDic.ContainsKey(work.Source.Name))
                {
                    sourceSumDic[work.Source.Name] += (work.Prepay + work.Excess);
                }
                else
                {
                    sourceSumDic.Add(work.Source.Name, work.Prepay + work.Excess);
                }
                if (sourceCountDic.ContainsKey(work.Source.Name))
                {
                    sourceCountDic[work.Source.Name] += 1;
                }
                else
                {
                    sourceCountDic.Add(work.Source.Name, 1);
                }
            }

            chrtSourceSum.Series["serIncSum"].Points.DataBind(incSumDic, "Key", "Value", "");
            chrtSourceSum.Series["serIncCount"].Points.DataBind(incCountDic, "Key", "Value", "");
            chrtSourceSum.Series["serSourceSum"].Points.DataBind(sourceSumDic, "Key", "Value", "");
            chrtSourceSum.Series["serSourceCount"].Points.DataBind(sourceCountDic, "Key", "Value", "");

            var consWorkDic = new Dictionary<string, double>();
            var consTypeDic = new Dictionary<string, double>();
            foreach (var cons in monthConsLst)
            {
                if (consTypeDic.ContainsKey(cons.Type.Name))
                {
                    consTypeDic[cons.Type.Name] += cons.Amount;
                }
                else
                {
                    consTypeDic.Add(cons.Type.Name, cons.Amount);
                }

                if (cons.WorkId == null) continue;
                if (consWorkDic.ContainsKey(cons.Work.Type.Name))
                {
                    consWorkDic[cons.Work.Type.Name] += cons.Amount;
                }
                else
                {
                    consWorkDic.Add(cons.Work.Type.Name, cons.Amount);
                }


            }
            chrtSourceSum.Series["serConsWork"].Points.DataBind(consWorkDic, "Key", "Value", "");
            chrtSourceSum.Series["serConsType"].Points.DataBind(consTypeDic, "Key", "Value", "");

            var incMonthDic = new Dictionary<string, double>();
            var incMonthPDic = new Dictionary<string, double>();
            foreach (var work in yearWorkLst)
            {
                if (incMonthDic.ContainsKey(work.DatePay.ToString("MMMM")))
                {
                    incMonthDic[work.DatePay.ToString("MMMM")] += (work.Prepay + work.Excess);
                }
                else
                {
                    incMonthDic.Add(work.DatePay.ToString("MMMM"), work.Prepay + work.Excess);
                }
            }
            foreach (var work in pastYearWorkLst)
            {
                if (incMonthPDic.ContainsKey(work.DatePay.ToString("MMMM")))
                {
                    incMonthPDic[work.DatePay.ToString("MMMM")] += (work.Prepay + work.Excess);
                }
                else
                {
                    incMonthPDic.Add(work.DatePay.ToString("MMMM"), work.Prepay + work.Excess);
                }
            }
            chrtSourceSum.Series["serMonth"].Points.DataBind(incMonthDic, "Key", "Value", "");
            chrtSourceSum.Series["serMonthP"].Points.DataBind(incMonthPDic, "Key", "Value", "");

            var certs = WorkLib.GetYearCerts(_currentDate).ToList();
            var certIncDic = new Dictionary<string, double>();
            var certConsDic = new Dictionary<string, double>();
            if (certs.Any())
            {
                var certDic = new Dictionary<int, double>();
                foreach (var cert in certs)
                {
                    if (certDic.ContainsKey(cert.DatePay.Month))
                    {
                        certDic[cert.DatePay.Month] += cert.Price;
                    }
                    else { certDic.Add(cert.DatePay.Month, cert.Price); }
                }
                for (var i = 1 ; i<=12;i++)
                {
                    var tdate = new DateTime(DateTime.Now.Year, i, 1);
                    var iMonth = i;
                    certIncDic.Add(tdate.ToString("MMMM"), certDic.Where(r => r.Key <= iMonth).Sum(r => r.Value));
                }
                //certIncDic.Add("Сертификаты", certs.Sum(r => r.Price));
            }
            if (yearConsList.Any(r => r.IsCert))
            {
                var certDic = new Dictionary<int, double>();
                foreach (var cert in yearConsList.Where(r => r.IsCert))
                {
                    if (certDic.ContainsKey(cert.Date.Month))
                    {
                        certDic[cert.Date.Month] += cert.Amount;
                    }
                    else { certDic.Add(cert.Date.Month, cert.Amount); }
                }
                for (var i = 1; i <= 12; i++)
                {
                    var tdate = new DateTime(DateTime.Now.Year, i, 1);
                    var iMonth = i;
                    certConsDic.Add(tdate.ToString("MMMM"), certDic.Where(r => r.Key <= iMonth).Sum(r => r.Value));
                }
                //certConsDic.Add("Сертификаты", yearConsList.Where(r => r.Type.IsCertCons).Sum(r => r.Amount));
            }
            chrtSourceSum.Series["serCertInc"].Points.DataBind(certIncDic, "Key", "Value", "");
            chrtSourceSum.Series["serCertCons"].Points.DataBind(certConsDic, "Key", "Value", "");
            #endregion
            
        }
        private void WorkLoad(IEnumerable<EWork> works)
        {
            try
            {
                grWork.Rows.Clear();
                //grWork.RowCount = 1;
                foreach (var work in works)
                {
                    grWork.RowCount = grWork.RowCount + 1;
                    var iRow = grWork.Rows[grWork.RowCount - 2].Cells;
                    iRow["cwNumber"].Value = grWork.RowCount - 1;
                    iRow["cwId"].Value = work.Id;
                    iRow["cwClientId"].Value = work.ClientId;
                    iRow["cwClient"].Value = work.Client.Name;
                    iRow["cwTypeId"].Value = work.TypeId;
                    iRow["cwType"].Value = work.Type.Name;
                    iRow["cwDatePay"].Value = work.DatePay.ToString("dd.MM.yyyy");
                    iRow["cwPrepay"].Value = work.Prepay;
                    iRow["cwDuty"].Value = work.Duty; 
                    iRow["cwExcess"].Value = work.Return(r => r.Excess, 0);
                    iRow["cwDateExcess"].Value = work.Return(r => r.DateExcess != null ? r.DateExcess.Value.ToString("dd.MM.yyyy") : "", "");
                    iRow["cwCons"].Value = work.Cons;
                    iRow["cwHours"].Value = work.Hours;
                    iRow["cwSourceId"].Value = work.SourceId;
                    iRow["cwSource"].Value = work.Source.Name;
                    iRow["cwCertId"].Value = work.CertId;
                    iRow["cwCert"].Value = work.CertId != null;
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
                    Errors.SaveError(ex, cName + "/" + mName);
                }
            }
        }
        private void SaveChanges()
        {
            using (var db = new OrderContext())
            {
                var t = db.Database.BeginTransaction();
                try
                {

                    #region SaveWorks

                    foreach (DataGridViewRow row in grWork.Rows)
                    {
                        var rowId = row.Index;
                        var work = new EWork();
                        double excess;
                        try
                        {
                            work.Id = Convert.ToInt32(row.Cells["cwId"].Value);
                        }
                        catch
                        {
                            work.Id = 0;
                        }
                        try
                        {
                            work.ClientId = Convert.ToInt32(row.Cells["cwClientId"].Value);
                        }
                        catch
                        {
                            work.ClientId = 0;
                        }
                        try
                        {
                            var dateStr = row.Cells["cwDatePay"].Value.ToString().Trim();
                            dateStr = Regex.Replace(dateStr, ",", ".");
                            work.DatePay = Convert.ToDateTime(dateStr);
                        }
                        catch
                        {
                            work.DatePay = DateTime.Now;
                        }
                        try
                        {
                            var payStr = row.Cells["cwPrepay"].Value.ToString().Trim();
                            payStr = payStr.Replace(".", ",");
                            work.Prepay = Convert.ToDouble(payStr);
                        }
                        catch
                        {
                            work.Prepay = 0;
                        }
                        try
                        {
                            var dutyStr = row.Cells["cwDuty"].Value.ToString().Trim();
                            dutyStr = Regex.Replace(dutyStr, " +", "");
                            dutyStr = dutyStr.Replace(".", ",");
                            work.Duty = Convert.ToDouble(dutyStr);
                        }
                        catch
                        {
                            work.Duty = 0;
                        }
                        try
                        {
                            work.TypeId = Convert.ToInt32(row.Cells["cwTypeId"].Value);
                        }
                        catch
                        {
                            work.TypeId = 0;
                        }
                        try
                        {
                            var hoursStr = row.Cells["cwHours"].Value.ToString().Trim();
                            hoursStr = Regex.Replace(hoursStr, " +", "");
                            hoursStr = hoursStr.Replace(".", ",");
                            work.Hours = Convert.ToDouble(hoursStr);
                        }
                        catch
                        {
                            work.Hours = 0;
                        }
                        try
                        {
                            work.SourceId = Convert.ToInt32(row.Cells["cwSourceId"].Value);
                        }
                        catch
                        {
                            work.SourceId = 0;
                        }
                        try
                        {
                            work.CertId = Convert.ToInt32(row.Cells["cwCertId"].Value);
                            if (work.CertId == 0) work.CertId = null;
                        }
                        catch
                        {
                            work.CertId = null;
                        }
                        try
                        {
                            var payExcess = row.Cells["cwExcess"].Value.ToString().Trim();
                            payExcess = Regex.Replace(payExcess, " +", "");
                            excess = Convert.ToInt32(payExcess);
                        }
                        catch
                        {
                            excess = 0;
                        }
                        if (excess > 0)
                        {
                            work.Excess = excess;
                            try
                            {
                                var dateStr = row.Cells["cwDateExcess"].Value.ToString().Trim();
                                dateStr = Regex.Replace(dateStr, ",", ".");
                                work.DateExcess = Convert.ToDateTime(dateStr);
                            }
                            catch
                            {
                                work.DateExcess = DateTime.Now;
                            }

                        }
                        else
                        {
                            work.Excess = 0;
                            work.DateExcess = null;
                        }
                        if (work.TypeId == 0 || work.ClientId == 0 || work.SourceId == 0) continue;
                            //throw new ArgumentException("Ошибка данных в работах");

                        if (_workCerts.Select(r=>r.RowId).Contains(rowId))
                        {
                            var ch = (row.Cells["cwCert"] as DataGridViewCheckBoxCell);
                            var chVal = ch.EditingCellFormattedValue;
                            if (Convert.ToBoolean(chVal))
                            {
                                var cert = _workCerts.First(r => r.RowId == rowId);
                                cert.Hours = work.Hours;
                                cert.PayId = work.ClientId;
                                cert.Price = work.Prepay;
                                cert.SourceId = work.SourceId;
                                cert.TypeId = work.TypeId;
                                if (cert.Id == 0)
                                {
                                    cert = db.Certs.Add(cert);
                                }
                                else
                                {
                                    var tcert = db.Certs.Find(cert.Id);
                                    tcert.ClientId = cert.ClientId;
                                    tcert.Consed = cert.Consed;
                                    tcert.DateEnd = cert.DateEnd;
                                    tcert.DatePay = cert.DatePay;
                                    tcert.Hours = cert.Hours;
                                    tcert.PayId = cert.PayId;
                                    tcert.Price = cert.Price;
                                    tcert.SourceId = cert.SourceId;
                                    tcert.TypeId = cert.TypeId;
                                }

                                work.CertId = cert.Id;
                            }
                            else
                            {
                                work.CertId = 0;
                            }
                            _workCerts.RemoveAll(r => r.RowId == rowId);
                        }

                        if (work.Id == 0)
                        {
                            work = db.Works.Add(work);
                            db.SaveChanges();
                        }
                        else
                        {
                            var twork = db.Works.Find(work.Id);
                            twork.ClientId = work.ClientId;
                            twork.DatePay = work.DatePay;
                            twork.Prepay = work.Prepay;
                            twork.Duty = work.Duty;
                            twork.TypeId = work.TypeId;
                            twork.Hours = work.Hours;
                            twork.Excess = work.Excess;
                            twork.DateExcess = work.DateExcess;
                            twork.CertId = work.CertId;
                        }
                        var conses = _workConses.Where(r => r.RowId == rowId && r.Id == 0).ToList();
                        foreach (var cons in conses)
                        {
                            cons.Date = work.DatePay;
                            cons.WorkId = work.Id;
                        }
                        db.Conses.AddRange(conses);
                        _workConses.RemoveAll(r => r.RowId == rowId && r.Id == 0);
                        conses = _workConses.Where(r => r.RowId == rowId).ToList();
                        foreach (var cons in conses)
                        {
                            var dCons = db.Conses.Find(cons.Id);
                            dCons.TypeId = cons.TypeId;
                            dCons.Amount = cons.Amount;
                            dCons.Comment = cons.Comment;
                            dCons.Date = work.DatePay;
                            dCons.WorkId = work.Id;
                            dCons.IsCert = cons.IsCert;
                        }
                        _workConses.RemoveAll(r => r.RowId == rowId );

                        db.SaveChanges();
                    }


                    _workConses.Clear();
                    foreach (var i in _deleteWorkList)
                    {
                        var work = db.Works.Find(i);
                        if (work == null) continue;
                        var workCons = db.Conses.Where(r => r.WorkId == work.Id);
                        db.Conses.RemoveRange(workCons);
                        db.Works.Remove(work);
                    }
                    #endregion

                    #region SaveCons

                    foreach (DataGridViewRow row in grCons.Rows)
                    {
                        var cons = new ECons();
                        try
                        {
                            cons.Id = Convert.ToInt32(row.Cells["csId"].Value);
                        }
                        catch
                        {
                            cons.Id = 0;
                        }
                        try
                        {
                            cons.TypeId = Convert.ToInt32(row.Cells["csTypeId"].Value);
                        }
                        catch
                        {
                            cons.TypeId = 0;
                        }

                        try
                        {
                            var amount = row.Cells["csAmount"].Value.ToString().Trim();
                            amount = Regex.Replace(amount, " +", "");
                            amount = amount.Replace(".", ",");
                            cons.Amount = Convert.ToDouble(amount);
                        }
                        catch
                        {
                            cons.Amount = 0;
                        }
                        try
                        {
                            var comment = row.Cells["csComment"].Value.ToString().Trim();
                            comment = Regex.Replace(comment, " +", " ");
                            cons.Comment = comment;
                        }
                        catch
                        {
                            cons.Comment = null;
                        }
                        try
                        {
                            var date = row.Cells["csDate"].Value.ToString().Trim();
                            date = Regex.Replace(date, " +", " ");
                            date = Regex.Replace(date, ",", ".");
                            cons.Date = Convert.ToDateTime(date);
                        }
                        catch
                        {
                            cons.Date = DateTime.Now;
                        }
                        try
                        {
                            var isCertCell = row.Cells["csIsCert"] as DataGridViewCheckBoxCell;
                            var isCert = (null != isCertCell && null != isCertCell.Value && (bool)isCertCell.Value);
                            cons.IsCert = Convert.ToBoolean(isCert);
                        }
                        catch
                        {
                            cons.IsCert = false;
                        }
                        if (cons.TypeId == 0 || cons.Amount < 0.01 || cons.Date == DateTime.MinValue) continue;// throw new ArgumentException("Ошибка данных в расходах");
                        if (cons.Id == 0)
                        {
                            db.Conses.Add(cons);
                        }
                        else
                        {
                            var tcons = db.Conses.Find(cons.Id);
                            tcons.Amount = cons.Amount;
                            tcons.Comment = cons.Comment;
                            tcons.Date = cons.Date;
                            tcons.TypeId = cons.TypeId;
                        }
                    }
                    foreach (var i in _deleteConsList)
                    {
                        var cons = db.Conses.Find(i);
                        if (cons == null) continue;
                        db.Conses.Remove(cons);
                    }

                    db.SaveChanges();

                    #endregion

                    #region SaveClients

                    foreach (DataGridViewRow row in grDicClient.Rows)
                    {
                        var client = new EClient();
                        try
                        {
                            client.Id = Convert.ToInt32(row.Cells["Id"].Value);
                        }
                        catch
                        {
                            client.Id = 0;
                        }
                        try
                        {
                            var name = row.Cells["Name"].Value.ToString().Trim();
                            name = Regex.Replace(name, " +", " ");
                            client.Name = name;
                        }
                        catch
                        {
                            client.Name = null;
                        }

                        try
                        {
                            var phone = row.Cells["Phone"].Value.ToString().Trim();
                            phone = Regex.Replace(phone, " +", " ");
                            client.Phone = phone;
                        }
                        catch
                        {
                            client.Phone = null;
                        }
                        try
                        {
                            var mail = row.Cells["Mail"].Value.ToString().Trim();
                            mail = Regex.Replace(mail, " +", " ");
                            client.Mail = mail;
                        }
                        catch
                        {
                            client.Mail = null;
                        }
                        try
                        {
                            var note = row.Cells["Note"].Value.ToString().Trim();
                            note = Regex.Replace(note, " +", " ");
                            client.Note = note;
                        }
                        catch
                        {
                            client.Note = null;
                        }
                        if (client.Id == 0 || string.IsNullOrEmpty(client.Name)) continue;// throw new ArgumentException("Ошибка данных в кликнтах");
                        var tclient = db.Clients.Find(client.Id);
                        tclient.Name = client.Name;
                        tclient.Phone = client.Phone;
                        tclient.Mail = client.Mail;
                        tclient.Note = client.Note;
                    }
                    db.SaveChanges();

                    #endregion

                    #region SaveCerts

                    foreach (DataGridViewRow row in grCert.Rows)
                    {
                        var cert = new ECert();
                        try
                        {
                            cert.Id = Convert.ToInt32(row.Cells["ccId"].Value);
                        }
                        catch
                        {
                            cert.Id = 0;
                        }
                        try
                        {
                            cert.ClientId = Convert.ToInt32(row.Cells["ccClientId"].Value);
                        }
                        catch
                        {
                            cert.ClientId = null;
                        }

                        try
                        {
                            cert.PayId = Convert.ToInt32(row.Cells["ccPayerId"].Value);
                        }
                        catch
                        {
                            cert.PayId = 0;
                        }

                        try
                        {
                            var dateStr = row.Cells["ccDatePay"].Value.ToString().Trim();
                            cert.DatePay = Convert.ToDateTime(dateStr);
                        }
                        catch
                        {
                            cert.DatePay = DateTime.Now;
                        }
                        try
                        {
                            var dateStr = row.Cells["ccDateEnd"].Value.ToString().Trim();
                            cert.DateEnd = Convert.ToDateTime(dateStr);
                        }
                        catch
                        {
                            cert.DateEnd = DateTime.Now;
                        }
                        try
                        {
                            var prcStr = row.Cells["ccPrice"].Value.ToString().Trim();
                            prcStr = Regex.Replace(prcStr, " +", "");
                            prcStr = prcStr.Replace(".", ",");
                            cert.Price = Convert.ToDouble(prcStr);
                        }
                        catch
                        {
                            cert.Price = 0;
                        }
                        try
                        {
                            var consStr = row.Cells["ccConsed"].Value.ToString().Trim();
                            consStr = Regex.Replace(consStr, " +", "");
                            consStr = consStr.Replace(".", ",");
                            cert.Consed = Convert.ToDouble(consStr);
                        }
                        catch
                        {
                            cert.Consed = 0;
                        }
                        try
                        {
                            var hourStr = row.Cells["ccHours"].Value.ToString().Trim();
                            hourStr = Regex.Replace(hourStr, " +", "");
                            hourStr = hourStr.Replace(".", ",");
                            cert.Hours = Convert.ToDouble(hourStr);
                        }
                        catch
                        {
                            cert.Hours = 0;
                        }
                        try
                        {
                            cert.SourceId = Convert.ToInt32(row.Cells["ccSourceId"].Value);
                        }
                        catch
                        {
                            cert.SourceId = 0;
                        }
                        try
                        {
                            cert.TypeId = Convert.ToInt32(row.Cells["ccTypeId"].Value);
                        }
                        catch
                        {
                            cert.TypeId = 0;
                        }
                        try
                        {
                            var ch = (row.Cells["ccIsCash"] as DataGridViewCheckBoxCell);
                            var chVal = ch.EditingCellFormattedValue;
                            cert.IsCash = Convert.ToBoolean(chVal);
                        }
                        catch
                        {
                            cert.IsCash = false;
                        }

                        if (cert.ClientId == 0 || cert.PayId == 0 || cert.SourceId == 0 || cert.TypeId == 0) continue;// throw new ArgumentException("Ошибка данных в сертификатах");
                        if (cert.Id == 0)
                        {
                            db.Certs.Add(cert);
                        }
                        else
                        {
                            var tcert = db.Certs.Find(cert.Id);
                            tcert.ClientId = cert.ClientId;
                            tcert.Consed = cert.Consed;
                            tcert.DatePay = cert.DatePay;
                            tcert.DateEnd = cert.DateEnd;
                            tcert.Hours = cert.Hours;
                            tcert.PayId = cert.PayId;
                            tcert.Price = cert.Price;
                            tcert.SourceId = cert.SourceId;
                            tcert.TypeId = cert.TypeId;
                            tcert.IsCash = cert.IsCash;
                        }
                    }
                    db.SaveChanges();

                    #endregion

                    #region SaveDuty

                    foreach (DataGridViewRow row in grDuty.Rows)
                    {
                        var work = new EWork();
                        var confirm = 0D;
                        try
                        {
                            work.Id = Convert.ToInt32(row.Cells["cdId"].Value);
                        }
                        catch
                        {
                            work.Id = 0;
                        }
                        try
                        {
                            var payStr = row.Cells["cdConfirm"].Value.ToString().Trim();
                            payStr = Regex.Replace(payStr, " +", "");
                            payStr = payStr.Replace(".", ",");
                            confirm = Convert.ToDouble(payStr);
                        }
                        catch
                        {
                            work.Prepay = 0;
                        }

                        if (work.Id == 0 || confirm < 0.01) continue;
                        //throw new ArgumentException("Ошибка данных в работах");


                        var twork = db.Works.Find(work.Id);
                        if(twork.Duty<confirm) continue;
                        if (twork.Excess < 0.01)
                        {
                            twork.Excess = confirm;
                            twork.DateExcess = DateTime.Now;
                        }
                        else
                        {
                            twork.Excess = twork.Excess + confirm;
                        }
                        twork.Duty = twork.Duty - confirm;
                        db.SaveChanges();
                    }

                    #endregion

                    t.Commit();
                    MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                    _hasChange = false;
                    //_currentDate = DateTime.Now;
                }
                catch (ArgumentException ex)
                {
                    t.Rollback();
                    MessageBox.Show(ex.Message, Resources.Orders, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(ex, cName + "/" + mName);
                    }
                    return;
                }
                GridMonthLoad(_currentDate);
                LoadCerts();
                LoadDuty();
            }
        }

        #endregion

        #region Вкладка графики

        private void chrtSourceSum_MouseLeave(object sender, EventArgs e)
        {
            if (chrtSourceSum.Focused)
                chrtSourceSum.Parent.Focus();
        }

        private void chrtSourceSum_MouseEnter(object sender, EventArgs e)
        {
            if (!chrtSourceSum.Focused)
                chrtSourceSum.Focus();
        }

        #endregion

        #region Вкладка Сертификаты

        private void grCert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;

            switch (grCert.Columns[iCol].Name)
            {
                case "ccPayer":
                    var frP = new FrClient();
                    string pName;
                    try
                    {
                        pName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch
                    {
                        pName = "";
                    }
                    frP.ClientName = new EClient { Name = pName };
                    frP.ShowDialog();
                    if (frP.ClientName!= null&&frP.ClientName.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["ccPayerId"].Value = frP.ClientName.Id;
                        grCert.Rows[iRow].Cells["ccPayer"].Value = frP.ClientName.Name;
                    }
                    break;
                case "ccClient":
                    var frC = new FrClient();
                    string cName;
                    try
                    {
                        cName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch
                    {
                        cName = "";
                    }
                    frC.ClientName = new EClient { Name = cName };
                    frC.ShowDialog();
                    if (frC.ClientName!=null&&frC.ClientName.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["ccClientId"].Value = frC.ClientName.Id;
                        grCert.Rows[iRow].Cells["ccClient"].Value = frC.ClientName.Name;
                    }
                    break; 
                        case "ccType":
                    var frW = new FrWorkType();
                    string tName;
                    try
                    {
                        tName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch
                    {
                        tName = "";
                    }
                    frW.WorkType = new EWorkType {Name = tName};
                    frW.ShowDialog();
                    if (frW.WorkType!=null&&frW.WorkType.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["ccTypeId"].Value = frW.WorkType.Id;
                        grCert.Rows[iRow].Cells["ccType"].Value = frW.WorkType.Name;
                    }
                    break;
                        case "ccSource":
                    var frS = new FrSource();
                    string sName;
                    try
                    {
                        sName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch
                    {
                        sName = "";
                    }
                    frS.Source = new ESourceType { Name = sName };
                    frS.ShowDialog();
                    if (frS.Source != null && frS.Source.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["ccSourceId"].Value = frS.Source.Id;
                        grCert.Rows[iRow].Cells["ccSource"].Value = frS.Source.Name;
                    }
                    break;
            }
        }
        private void CertGraph(){
            
        }
        private void LoadCerts() {
            var certs = chCertAll.Checked ? WorkLib.GetCerts(_currentDate) : WorkLib.GetCerts();
            grCert.Rows.Clear();
            foreach (var cert in certs)
            {
                grCert.RowCount = grCert.RowCount + 1;
                var iRow = grCert.Rows[grCert.RowCount - 2].Cells;
                iRow["ccNumber"].Value = grCert.RowCount - 1;
                iRow["ccId"].Value = cert.Id;
                iRow["ccClientId"].Value = cert.ClientId;
                iRow["ccClient"].Value = cert.Client.Return(r => r.Name, "");
                iRow["ccPayerId"].Value = cert.PayId;
                iRow["ccPayer"].Value = cert.Payer.Name;
                iRow["ccTypeId"].Value = cert.TypeId;
                iRow["ccType"].Value = cert.Type.Name;
                iRow["ccDatePay"].Value = cert.DatePay.ToString("dd.MM.yyyy");
                iRow["ccDateEnd"].Value = cert.DateEnd.ToString("dd.MM.yyyy");
                iRow["ccPrice"].Value = cert.Price;
                iRow["ccConsed"].Value = cert.Consed;
                iRow["ccHours"].Value = cert.Hours;
                iRow["ccSourceId"].Value = cert.SourceId;
                iRow["ccSource"].Value = cert.Source.Name;
                iRow["ccIsCash"].Value = cert.IsCash;
            }
        }
        private void chCertAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadCerts();
        }

        #endregion

        #region Вкладка Расходы

        private void ConsLoad(IEnumerable<ECons> conses)
        {
            try
            {
                grCons.Rows.Clear();
                foreach (var cons in conses)
                {
                    if (!chShowAll.Checked && cons.WorkId > 0) continue;
                    grCons.RowCount = grCons.RowCount + 1;
                    var iRow = grCons.Rows[grCons.RowCount - 2].Cells;
                    iRow["csNumber"].Value = grCons.RowCount - 1;
                    iRow["csId"].Value = cons.Id;
                    iRow["csTypeId"].Value = cons.TypeId;
                    iRow["csType"].Value = cons.With(r => r.Type).Return(r => r.Name, "");
                    iRow["csDate"].Value = cons.Date.ToString("dd.MM.yyyy");
                    iRow["csAmount"].Value = cons.Amount;
                    iRow["csComment"].Value = cons.Comment;
                    iRow["csWorkId"].Value = cons.With(r => r.Work).Return(r => r.DatePay.ToString("dd.MM.yyyy"), "");
                    iRow["csIsCert"].Value = cons.IsCert;
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
                    Errors.SaveError(ex, cName + "/" + mName);
                }
            }
        }
        private void chShowAll_CheckedChanged(object sender, EventArgs e)
        {
            var monthConsLst = WorkLib.GetMonthConses(_currentDate).ToList();
            ConsLoad(monthConsLst);
        }
        private void grCons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grCons.Columns[iCol].Name)
            {
                case "csType":
                    using (var fr = new FrConsType())
                    {
                        string type;
                        try
                        {
                            type = grCons.Rows[iRow].Cells["csType"].Value.ToString();
                        }
                        catch
                        {
                            type = "";
                        }
                        fr.ConsType = new EConsType {Name = type};
                        fr.ShowDialog(this);
                        if (fr.ConsType != null && fr.ConsType.Id > 0)
                        {
                            grCons.Rows[iRow].Cells["csTypeId"].Value = fr.ConsType.Id;
                            grCons.Rows[iRow].Cells["csType"].Value = fr.ConsType.Name;
                        }
                    }
                    break;
                case "csDelete":
                    var res = MessageBox.Show(Resources.DeleteRecord, Resources.Orders, MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            var id = Convert.ToInt32(grCons.Rows[iRow].Cells["csId"].Value);
                            _deleteConsList.Add(id);
                        }
                        catch
                        {

                        }
                        grCons.Rows.RemoveAt(iRow);
                        _hasChange = true;
                    }
                    break;
            }
        }
        private void grCons_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
        }

        #endregion

        #region Вкладка Долги

        private void LoadDuty()
        {
            var dutyList = WorkLib.GetDuty().ToList();
            grDuty.Rows.Clear();
            //grWork.RowCount = 1;
            foreach (var work in dutyList)
            {
                grDuty.RowCount = grDuty.RowCount + 1;
                var iRow = grDuty.Rows[grDuty.RowCount - 1].Cells;
                iRow["cdNumber"].Value = grDuty.RowCount;
                iRow["cdId"].Value = work.Id;
                iRow["cdClient"].Value = work.With(r => r.Client).Return(r => r.Name, "");
                iRow["cdType"].Value = work.With(r => r.Type).Return(r => r.Name, "");
                iRow["cdDate"].Value = work.DatePay.ToString("dd.MM.yyyy");
                iRow["cdDuty"].Value = work.Duty;
                iRow["cdHours"].Value = work.Hours;
            }
            lVirt.Text = dutyList.Sum(r => r.Duty).ToString("# ### ##0");
        }
        private void grDuty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grDuty.Columns[iCol].Name)
            {
                case "cdConfirmAll":
                    int id;
                    try
                    {
                        id = Convert.ToInt32(grDuty.Rows[iRow].Cells["cdId"].Value);
                    }
                    catch
                    {
                        id = 0;
                    }
                    if (id > 0)
                    {
                        using (var db = new OrderContext())
                        {


                            var work = db.Works.Find(id);
                            grDuty.Rows[iRow].Cells["cdConfirm"].Value = work.Duty;
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Вкладка Справочник

        private void GetClients()
        {
            try
            {
                FilterClients();
                var cId = grDicClient.Columns["Id"];
                if (cId != null)
                {
                    cId.Visible = false;
                    cId.ReadOnly = true;
                }
                var cName = grDicClient.Columns["Name"];
                if (cName != null)
                {
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cName.HeaderText = Resources.Name;
                }
                var cPhone = grDicClient.Columns["Phone"];
                if (cPhone != null)
                {
                    cPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cPhone.HeaderText = Resources.Phone;
                }
                var cEmail = grDicClient.Columns["Mail"];
                if (cEmail != null)
                {
                    cEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cEmail.HeaderText = Resources.Email;
                }
                var cNote = grDicClient.Columns["Note"];
                if (cNote != null)
                {
                    cNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cNote.HeaderText = Resources.Note;
                }
                var cDateP = grDicClient.Columns["idate"];
                if (cDateP != null)
                {
                    cDateP.Visible = false;
                }

                var cDate = grDicClient.Columns["Date"];
                if (cDate != null)
                {
                    cDate.HeaderText = Resources.CreateDate;
                    cDate.Width = 100;
                    cDate.Resizable = DataGridViewTriState.False;
                }
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception, cName + "/" + mName);
                }
            }
        }
        private void tbFindClient_KeyUp(object sender, KeyEventArgs e)
        {
            FilterClients();
        }
        private void FilterClients()
        {
            using (var db = new OrderContext())
            {
                var text = tbFindClient.Text.Trim();
                text = Regex.Replace(text, " +", " ");
                var clients = db.Clients.ToList();
                if (!string.IsNullOrEmpty(text))
                    clients = clients.Where(r =>
                        (!string.IsNullOrEmpty(r.Name) && r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1) ||
                        (!string.IsNullOrEmpty(r.Phone) && r.Phone.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1) ||
                        (!string.IsNullOrEmpty(r.Mail) && r.Mail.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1)).ToList();
                clients.Sort((item1, item2) =>
                {
                    var order1 = item2.Date.CompareTo(item1.Date);
                    return order1 == 0 ? String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) : order1;
                });
                grDicClient.DataSource = new SortableBindingList<EClient>(clients);
            }
        }
        
        #endregion

        #region Вкладка Архив

        private void cbArchYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var date = new DateTime(Convert.ToInt32(cbArchYear.SelectedItem), 1, 1);
                var yearCons = WorkLib.GetYearConses(date).ToList();
                var yearWork = WorkLib.GetYearWorks(date).ToList();
                var sumInc = 0D;
                var sumCons = 0D;
                var sumHour = 0D;
                for (var i = 1; i <= 12; i++)
                {
                    var dateStart = new DateTime(date.Year, i, 1);
                    var dateEnd = dateStart.AddMonths(1);
                    var monthInc = yearWork.Where(
                        r => r.DatePay >= dateStart && r.DatePay < dateEnd)
                        .Sum(r => r.Return(l => l.Prepay, 0) + r.Return(l => l.Excess, 0));
                    var monthHour = yearWork.Where(
                        r => r.DatePay >= dateStart && r.DatePay < dateEnd)
                        .Sum(r => r.Return(l => l.Hours, 0));
                    var monthCons = yearCons.Where(r => r.Date >= dateStart && r.Date < dateEnd)
                        .Sum(r => r.Return(l => l.Amount, 0));
                    sumInc += monthInc;
                    sumHour += monthHour;
                    sumCons += monthCons;
                    Controls.Find("lArcInc" + i, true)[0].Text = monthInc.ToString("### ### ##0");
                    Controls.Find("lArcHour" + i, true)[0].Text = monthHour.ToString("### ### ##0");
                    Controls.Find("lArcCons" + i, true)[0].Text = monthCons.ToString("### ### ##0");
                    Controls.Find("lArcProf" + i, true)[0].Text = (monthInc - monthCons).ToString("### ### ##0");
                }
                var divider = date.Year == DateTime.Now.Year ? DateTime.Now.Month : 12;
                lArcIncAll.Text = sumInc.ToString("### ### ##0");
                lArcIncAvg.Text = (sumInc / divider).ToString("### ### ##0");
                lArcHourAll.Text = sumHour.ToString("### ### ##0");
                lArcHourAvg.Text = (sumHour / divider).ToString("### ### ##0");
                lArcConsAll.Text = sumCons.ToString("### ### ##0");
                lArcConsAvg.Text = (sumCons / divider).ToString("### ### ##0");
                lArcProfAll.Text = (sumInc - sumCons).ToString("### ### ##0");
                lArcProfAvg.Text = ((sumInc - sumCons) / divider).ToString("### ### ##0");
            }
            catch
            {
                
            }

        }
        private void ArcHistory_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hasChange)
                {
                    var svResult = MessageBox.Show(Resources.ChangeData, Resources.Orders, MessageBoxButtons.YesNo);
                    if (svResult == DialogResult.Yes)
                    {
                        SaveChanges();
                    }
                }
                _hasChange = false;
                var button = sender as Button;
                if (button == null) return;
                _currentDate = new DateTime(Convert.ToInt32(cbArchYear.SelectedItem), Convert.ToInt32(button.Tag), 1);
                GridMonthLoad(_currentDate);
                tabApp.SelectTab(tabWork);
            }
            catch
            {
                
            }
        }

        #endregion

        #region Вкладка администрирования

        public void LoadErrors()
        {
            using (var db = new OrderContext())
            {
                var errors = db.Errors.ToList();
                errors.Sort((item1, item2) => item2.Date.CompareTo(item1.Date));
                grErrors.DataSource = errors;
                var cId = grErrors.Columns["Id"];
                if (cId != null) cId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                var cDate = grErrors.Columns["Date"];
                if (cDate != null) cDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                var cMessage = grErrors.Columns["Message"];
                if (cMessage != null) cMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                var cFunction = grErrors.Columns["Function"];
                if (cFunction != null) cFunction.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void btReloadErrors_Click(object sender, EventArgs e)
        {
            LoadErrors();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                try
                {
                    db.Errors.RemoveRange(db.Errors);
                    db.SaveChanges();
                    LoadErrors();
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }

            }
        }
        private void btBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                const string fileName = "Order";
                var path = AppDomain.CurrentDomain.BaseDirectory + fileName + ".db";
                if (File.Exists(path))
                {
                    if (sdBackUp.ShowDialog() == DialogResult.OK)
                    {
                        var file = sdBackUp.SelectedPath + "\\" + fileName + ".db";
                        var i = 1;
                        while (File.Exists(file))
                        {
                            file = sdBackUp.SelectedPath + "\\" + fileName + "[" + i + "]" + ".db";
                            i++;
                        }
                        File.Copy(path, file);
                        MessageBox.Show(Resources.OK);
                    }
                }
                else
                {
                    MessageBox.Show(path);
                }
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception, cName + "/" + mName);
                }
                MessageBox.Show(Resources.Error);
            }
        }

        #endregion
    }
}
