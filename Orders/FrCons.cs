using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrCons : Form
    {
        #region Поля класса

        public int WorkId;
        public List<int> ConsId = new List<int>();
        public List<ECons> Conses = new List<ECons>();
        public bool FrOk;
        public readonly List<int> DeleteConsList = new List<int>(); 

        #endregion

        #region Управление формой

        public FrCons()
        {
            InitializeComponent();
        }
        private void FrCons_Load(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                FrOk = false;
                if (WorkId != 0)
                {
                    var conses = db.Conses.Where(r => r.WorkId == WorkId).ToList();
                    conses.RemoveAll(r => Conses.Select(l => l.Id).Contains(r.Id));
                    Conses.AddRange(conses);
                }
                ConsLoad(Conses);
            }
        }

        #endregion

        #region Работа формы
        
        private void ConsLoad(IEnumerable<ECons> list)
        {
            using (var db = new OrderContext())
            {
                grCons.Rows.Clear();
                try
                {
                    foreach (var cons in list)
                    {
                        var iRow = grCons.RowCount - 1;
                        grCons.RowCount = grCons.RowCount + 1;
                        var row = grCons.Rows[iRow];
                        row.Cells["cId"].Value = cons.Id;
                        row.Cells["cTypeId"].Value = cons.TypeId;
                        row.Cells["cType"].Value = db.ConsTypes.Find(cons.TypeId).Return(r => r.Name, "");
                        row.Cells["cComment"].Value = cons.Comment;
                        row.Cells["cAmount"].Value = cons.Amount;
                        row.Cells["cIsCert"].Value = cons.IsCert;
                    }
                }
                catch (Exception exception)
                {
                    Errors.HandleError(MethodBase.GetCurrentMethod(), exception);
                }
            }
        }
        private void grCons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grCons.Columns[iCol].Name)
            {
                case "cType":
                    using (var fr = new FrConsType())
                    {
                        string type;
                        try
                        {
                            type = grCons.Rows[iRow].Cells[iCol].Value.ToString();
                        }
                        catch
                        {
                            type = "";
                        }
                        fr.ConsType = new EConsType { Name = type };
                        fr.ShowDialog(this);
                        if (fr.ConsType != null && fr.ConsType.Id > 0)
                        {
                            grCons.Rows[iRow].Cells["cTypeId"].Value = fr.ConsType.Id;
                            grCons.Rows[iRow].Cells["cType"].Value = fr.ConsType.Name;
                        }
                    }
                    break;
                case "cDelete":
                    var res = MessageBox.Show(Resources.DeleteRecord, Resources.Orders, MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            var id = Convert.ToInt32(grCons.Rows[iRow].Cells["cId"].Value);
                            DeleteConsList.Add(id);
                        }
                        catch
                        {

                        }
                        grCons.Rows.RemoveAt(iRow);
                    }
                    break;
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                Conses.Clear();
                var rows = grCons.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    var cons = new ECons();
                    try
                    {
                        cons.Id = Convert.ToInt32(row.Cells["cId"].Value);
                    }
                    catch
                    {
                        cons.Id = 0;
                    }
                    try
                    {
                        cons.TypeId = Convert.ToInt32(row.Cells["cTypeId"].Value);
                    }
                    catch
                    {
                        cons.TypeId = 0;
                    }
                    try
                    {
                        var comment = row.Cells["cComment"].Value.ToString().Trim();
                        comment = Regex.Replace(comment, " +", " ");
                        cons.Comment = comment;
                    }
                    catch
                    {
                        cons.Comment = "";
                    }
                    try
                    {
                        var amount = row.Cells["cAmount"].Value.ToString().Trim();
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
                        var isCertCell = row.Cells["cIsCert"] as DataGridViewCheckBoxCell;
                        var isCert = (null != isCertCell && null != isCertCell.Value && (bool)isCertCell.Value);
                        cons.IsCert = Convert.ToBoolean(isCert);
                    }
                    catch
                    {
                        cons.IsCert = false;
                    }
                    if (cons.TypeId == 0 || cons.Amount < 0.01) continue;
                    Conses.Add(cons);
                }
                Close();
                FrOk = true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show(Resources.CheckInputData, Resources.Orders, MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                Errors.HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            var text = tbFind.Text.Trim();
            text = Regex.Replace(text, " +", " ");
            var conses = string.IsNullOrEmpty(text)
                ? Conses
                : Conses.Where(r => r.With(l => l.Type).Return(l => l.Name, "")
                    .IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
            ConsLoad(conses);
        }
        
        #endregion

        
    }
}
