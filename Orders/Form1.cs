using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Properties;
using System.Text.RegularExpressions;
using Button = System.Windows.Forms.Button;

namespace Orders
{
    public partial class Form1 : Form
    {
        #region Поля класса
        
        readonly OrderContext _db = new OrderContext();
        private bool _hasChange;
        private readonly Dictionary<int, int> _workCons = new Dictionary<int, int>();
        private readonly List<ECons> _workConses = new List<ECons>();
        private readonly Dictionary<int, int> _certCons = new Dictionary<int, int>();
        private readonly int _currentYear = DateTime.Now.Year;
        private DateTime _currentDate = DateTime.Now;
        private readonly List<int> _deleteWorkList = new List<int>();
        private readonly List<int> _deleteConsList = new List<int>(); 

        private enum TableCol
        {
            PreDateColIndex = 6,
            ExDateColIndex = 9,
        }
        
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
                ControlLoad();
                _currentDate = DateTime.Now;
                GridMonthLoad(_currentDate);

                var minDate = WorkLib.GetMinDate();
                for (var i = minDate.Year; i < DateTime.Now.Year; i++)
                {
                    cbArchYear.Items.Add(i);
                }

                var fr = new FrEvents();
                fr.Top = Top + ClientSize.Height - fr.Height;
                fr.Left = Left + ClientSize.Width - fr.Width;
                fr.Show();
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
            }
            //tabArchive.Dispose();
            _hasChange = false;
        }
        private void ControlLoad()
        {
            try
            {
                var date = new CalendarColumn
                {
                    Name = "cwDatePay",
                    DataPropertyName = "cwDatePay",
                    HeaderText = Resources.Date,
                    Width = 120
                };
                grWork.Columns.Insert((int)TableCol.PreDateColIndex, date);

                date = new CalendarColumn
                {
                    Name = "cwDateExcess",
                    DataPropertyName = "cwDateExcess",
                    HeaderText = Resources.ExDate,
                    Width = 120
                };
                grWork.Columns.Insert((int)TableCol.ExDateColIndex, date);

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
            var button = sender as Button;
            if (button == null) return;
            _currentDate = new DateTime(_currentYear, Convert.ToInt32(button.Tag), 1);
            GridMonthLoad(_currentDate);
            _hasChange = false;
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
                        frCons.CertId = 0;
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
                    fr.ShowDialog();
                    try
                    {
                        if (fr.ClientName == null) return;
                        grWork.Rows[iRow].Cells["cwClientId"].Value = fr.ClientName.Id;
                        grWork.Rows[iRow].Cells["cwClient"].Value = fr.ClientName.Name;
                    }
                    catch (Exception exception)
                    {
                        var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                        if (declaringType != null)
                        {
                            var cName = declaringType.Name;
                            var mName = MethodBase.GetCurrentMethod().Name;
                            Errors.SaveError(exception.Message, cName + "/" + mName);
                        }
                    }
                    break;
                case "cwType":
                    var frWType = new FrWorkType();
                    frWType.ShowDialog();
                    if (frWType.WorkType != null)
                    {
                        grWork.Rows[iRow].Cells["cwTypeId"].Value = frWType.WorkType.Id;
                        grWork.Rows[iRow].Cells["cwType"].Value = frWType.WorkType.Name;
                    }
                    break;
                case "cwSource":
                    var frSource = new FrSource();
                    frSource.ShowDialog();
                    if (frSource.Source != null)
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
                        grWork.Rows.RemoveAt(iRow);
                        _workConses.RemoveAll(r => r.RowId == iRow);
                        foreach (var cons in _workConses.Where(r => r.RowId > iRow))
                        {
                            cons.RowId = cons.RowId - 1;
                        }
                        _hasChange = true;
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
            var yearCons = WorkLib.GetYearConses(date).Sum(r => r.Return(l => l.Amount, 0));
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

                if(cons.WorkId==0)continue;
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
                    iRow["cwExcess"].Value = work.Return(r => r.Excess, 0);
                    iRow["cwDateExcess"].Value = work.Return(r => r.DateExcess != null ? r.DateExcess.Value.ToString("dd.MM.yyyy") : "", "");
                    iRow["cwCons"].Value = work.Cons;
                    iRow["cwHours"].Value = work.Hours;
                    iRow["cwSourceId"].Value = work.SourceId;
                    iRow["cwSource"].Value = work.Source.Name;
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
        }
        private void SaveChanges()
        {
            var t = _db.Database.BeginTransaction();
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
                        dateStr = System.Text.RegularExpressions.Regex.Replace(dateStr, " +", "");
                        dateStr = System.Text.RegularExpressions.Regex.Replace(dateStr, ",", ".");
                        work.DatePay = Convert.ToDateTime(dateStr);
                    }
                    catch
                    {
                        work.DatePay = DateTime.Now;
                    }
                    try
                    {
                        var payStr = row.Cells["cwPrepay"].Value.ToString().Trim();
                        payStr = System.Text.RegularExpressions.Regex.Replace(payStr, " +", "");
                        payStr = System.Text.RegularExpressions.Regex.Replace(payStr, ",", ".");
                        work.Prepay = Convert.ToDouble(payStr);
                    }
                    catch
                    {
                        work.Prepay = 0;
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
                        hoursStr = System.Text.RegularExpressions.Regex.Replace(hoursStr, " +", "");
                        hoursStr = System.Text.RegularExpressions.Regex.Replace(hoursStr, ",", ".");
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
                        var payExcess = row.Cells["cwExcess"].Value.ToString().Trim();
                        payExcess = System.Text.RegularExpressions.Regex.Replace(payExcess, " +", "");
                        payExcess = System.Text.RegularExpressions.Regex.Replace(payExcess, ",", ".");
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
                            dateStr = System.Text.RegularExpressions.Regex.Replace(dateStr, " +", "");
                            dateStr = System.Text.RegularExpressions.Regex.Replace(dateStr, ",", ".");
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
                    if (work.Id == 0)
                    {
                        work = _db.Works.Add(work);
                        _db.SaveChanges();
                    }
                    else
                    {
                        var twork = _db.Works.Find(work.Id);
                        twork.ClientId = work.ClientId;
                        twork.DatePay = work.DatePay;
                        twork.Prepay = work.Prepay;
                        twork.TypeId = work.TypeId;
                        twork.Hours = work.Hours;
                        twork.Excess = work.Excess;
                        twork.DateExcess = work.DateExcess;
                    }
                    var conses = _workConses.Where(r => r.RowId == rowId && r.Id == 0).ToList();
                    foreach (var cons in conses)
                    {
                        cons.Date = work.DatePay;
                        cons.WorkId = work.Id;
                    }
                    _db.Conses.AddRange(conses);
                    _workConses.RemoveAll(r => r.RowId == rowId && r.Id == 0);
                    conses = _workConses.Where(r => r.RowId == rowId).ToList();
                    foreach (var cons in conses)
                    {
                        var dCons = _db.Conses.Find(cons.Id);
                        dCons.TypeId = cons.TypeId;
                        dCons.Amount = cons.Amount;
                        dCons.Comment = cons.Comment;
                        dCons.Date = work.DatePay;
                        dCons.WorkId = work.Id;
                    }
                    _workConses.RemoveAll(r => r.RowId == rowId && r.Id == 0);
                    _db.SaveChanges();
                }
                

                _workConses.Clear();
                foreach (var i in _deleteWorkList)
                {
                    var work = _db.Works.Find(i);
                    if (work == null) continue;
                    var workCons = _db.Conses.Where(r => r.WorkId == work.Id);
                    _db.Conses.RemoveRange(workCons);
                    _db.Works.Remove(work);
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

                    try{
                        var amount = row.Cells["csAmount"].Value.ToString().Trim();
                        amount = Regex.Replace(amount, " +", "");
                        amount = amount.Replace(",", ".");
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
                        date = Regex.Replace(date, " +"," ");
                        date = Regex.Replace(date, ",", ".");
                        cons.Date = Convert.ToDateTime(date);
                    }
                    catch
                    {
                        cons.Date = DateTime.Now;
                    }
                    if (cons.TypeId == 0 || cons.Amount < 0.01 || cons.Date == DateTime.MinValue) continue;
                    if (cons.Id == 0)
                    {
                        _db.Conses.Add(cons);
                    }
                    else
                    {
                        var tcons = _db.Conses.Find(cons.Id);
                        tcons.Amount = cons.Amount;
                        tcons.Comment = cons.Comment;
                        tcons.Date = cons.Date;
                        tcons.TypeId = cons.TypeId;
                    }
                }
                foreach (var i in _deleteConsList)
                {
                    var cons = _db.Conses.Find(i);
                    if (cons == null) continue;
                    _db.Conses.Remove(cons);
                }
                _db.SaveChanges();
                
                #endregion
                
                t.Commit();
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                _hasChange = false;
                _currentDate = DateTime.Now;
                GridMonthLoad(_currentDate);
            }
            catch (Exception ex)
            {
                t.Rollback();
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
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
            var fr = new FrClient();
            switch (grCert.Columns[iCol].Name)
            {
                case "ccCons":
                    var frCons = new FrCons();
                    try
                    {
                    }
                    catch (Exception)
                    {
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
                    iRow["csWorkId"].Value = cons.WorkId;
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
        }
        private void chShowAll_CheckedChanged(object sender, EventArgs e)
        {
            var monthConsLst = WorkLib.GetMonthConses(_currentDate).ToList();
            ConsLoad(monthConsLst);
        }
        private void btConsSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
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
                        fr.ShowDialog(this);
                        if (fr.ConsType == null) return;
                        grCons.Rows[iRow].Cells["csTypeId"].Value = fr.ConsType.Id;
                        grCons.Rows[iRow].Cells["csType"].Value = fr.ConsType.Name;
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
                lArcIncAll.Text = sumInc.ToString("### ### ##0");
                lArcIncAvg.Text = (sumInc/12).ToString("### ### ##0");
                lArcHourAll.Text = sumHour.ToString("### ### ##0");
                lArcHourAvg.Text = (sumHour/12).ToString("### ### ##0");
                lArcConsAll.Text = sumCons.ToString("### ### ##0");
                lArcConsAvg.Text = (sumCons/12).ToString("### ### ##0");
                lArcProfAll.Text = (sumInc - sumCons).ToString("### ### ##0");
                lArcProfAvg.Text = ((sumInc - sumCons)/12).ToString("### ### ##0");
            }
            catch
            {
                return;
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
                var button = sender as Button;
                if (button == null) return;
                _currentDate = new DateTime(Convert.ToInt32(cbArchYear.SelectedItem), Convert.ToInt32(button.Tag), 1);
                GridMonthLoad(_currentDate);
                _hasChange = false;
                tabApp.SelectTab(tabWork);
            }
            catch
            {
                return;
            }
        }

        #endregion

        
    }
}
