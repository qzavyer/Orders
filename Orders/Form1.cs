using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Properties;
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
                GridMonthLoad(DateTime.Now);
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
            tabArchive.Dispose();
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
            var date = new DateTime(_currentYear, Convert.ToInt32(button.Tag), 1);
            GridMonthLoad(date);
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
                    frCons.Conses = _workConses.Where(r => r.RowId == iRow).ToList();
                    try
                    {
                        frCons.WorkId = Convert.ToInt32(grWork.Rows[iRow].Cells["cId"].Value);
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
                    if (frCons.Cons == null || !frCons.FrOk) return;
                    
                    var conses = frCons.Conses;
                    _workConses.RemoveAll(r => r.RowId == iRow);
                    foreach (var cons in conses)
                    {
                        cons.RowId = iRow;
                    }
                    _workConses.AddRange(conses);

                    grWork.Rows[iRow].Cells[iCol].Value = frCons.Conses.Sum(r => r.Amount);
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
                var dateStart = new DateTime(DateTime.Now.Year, i, 1);
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
            try
            {
                var t = _db.Database.BeginTransaction();
                foreach (DataGridViewRow row in grWork.Rows)
                {
                    var rowId = row.Cells["cwId"].Value;
                    EWork work;
                    if (string.IsNullOrEmpty(rowId.ToString().Trim()))
                    {
                        work = new EWork
                        {
                            ClientId = Convert.ToInt32(row.Cells["cwClientId"].Value.ToString().Trim()),
                            DatePay = Convert.ToDateTime(row.Cells["cwDatePay"].Value.ToString().Trim()),
                            Prepay = Convert.ToDouble(row.Cells["cwPrepay"].Value.ToString().Trim()),
                            TypeId = Convert.ToInt32(row.Cells["cwTypeId"].Value.ToString().Trim()),
                            Hours = Convert.ToDouble(row.Cells["cwHours"].Value.ToString().Trim()),
                            SourceId = Convert.ToInt32(row.Cells["cwSourceId"].Value.ToString().Trim())
                        };
                        if (!string.IsNullOrEmpty(row.Cells["cwExcess"].Value.ToString().Trim()))
                        {
                            work.Excess = Convert.ToDouble(row.Cells["cwExcess"].Value.ToString().Trim());
                            work.DateExcess = Convert.ToDateTime(row.Cells["cwDateExcess"].Value.ToString().Trim());
                        }
                        work = _db.Works.Add(work);
                        _db.SaveChanges();
                    }
                    else
                    {
                        work = _db.Works.Find(Convert.ToInt32(rowId));
                        work.ClientId = Convert.ToInt32(row.Cells["cwClientId"].Value.ToString().Trim());
                        work.DatePay = Convert.ToDateTime(row.Cells["cwDatePay"].Value.ToString().Trim());
                        work.Prepay = Convert.ToDouble(row.Cells["cwPrepay"].Value.ToString().Trim());
                        work.TypeId = Convert.ToInt32(row.Cells["cwTypeId"].Value.ToString().Trim());
                        work.Hours = Convert.ToDouble(row.Cells["cwHours"].Value.ToString().Trim());
                        if (!string.IsNullOrEmpty(row.Cells["cwExcess"].Value.ToString().Trim()))
                        {
                            work.Excess = Convert.ToDouble(row.Cells["cwExcess"].Value.ToString().Trim());
                            work.DateExcess = Convert.ToDateTime(row.Cells["cwDateExcess"].Value.ToString().Trim());
                        }                        
                    }
                    var conses = _workConses.Where(r => r.RowId ==Convert.ToInt32(rowId) && r.Id == 0);
                    _db.Conses.AddRange(conses);
                    _workConses.RemoveAll(r => r.RowId == Convert.ToInt32(rowId) && r.Id == 0);
                    conses = _workConses.Where(r => r.RowId == Convert.ToInt32(rowId));
                    foreach (var cons in conses)
                    {
                        var dCons = _db.Conses.Find(cons.Id);
                        dCons.TypeId = cons.TypeId;
                        dCons.Amount = cons.Amount;
                        dCons.Comment = cons.Comment;
                        dCons.Date = work.DatePay;
                    }
                    _workConses.RemoveAll(r => r.RowId == Convert.ToInt32(rowId) && r.Id == 0);
                }
                _db.SaveChanges();
                t.Commit();
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                _hasChange = false;
                GridMonthLoad(DateTime.Now);
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
                
    }
}
