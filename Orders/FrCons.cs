using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrCons : Form
    {
        #region Поля класса

        private static readonly OrderContext Db = new OrderContext();
        public readonly Cons Cons = new Cons();
        public int WorkId;
        public int CertId;
        public List<int> ConsId = new List<int>();
        public List<ECons> Conses = new List<ECons>();
        public DateTime WorkDate;
        public bool FrOk;
        private DataTable _consType;
        
        #endregion

        #region Управление формой

        public FrCons()
        {
            InitializeComponent();
        }
        private void FrCons_Load(object sender, EventArgs e)
        {
            ControlLoad();
            var conses = Db.Conses.Where(r => r.WorkId == WorkId && !Conses.Select(l => l.Id).Contains(r.Id)).ToList();
            ConsLoad(conses);
            Conses.AddRange(conses);
        }

        #endregion

        #region Работа формы
        
        private void ControlLoad()
        {
            
        }
        private void ConsLoad(List<ECons> list)
        {
            grCons.Rows.Clear();
            try
            {
                foreach (var cons in list)
                {
                    var iRow = grCons.RowCount-1;
                    grCons.RowCount = grCons.RowCount + 1;
                    var row = grCons.Rows[iRow];
                    row.Cells["cId"].Value = cons.Id;
                    row.Cells["cTypeId"].Value = cons.TypeId;
                    row.Cells["cType"].Value = cons.Type;
                    row.Cells["cComment"].Value = cons.Comment;
                    row.Cells["cAmount"].Value = cons.Amount;                    
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
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = grCons.Rows;
                foreach (DataGridViewRow row in rows)
                {
                    var cons = new ECons
                    {
                        Comment = row.Cells["ccComment"].Value.ToString().Trim(),
                        TypeId = string.IsNullOrEmpty(row.Cells["ccTypeId"].Value.ToString().Trim()) ? 0 : Convert.ToInt32(row.Cells["ccTypeId"].Value),
                        Id = string.IsNullOrEmpty(row.Cells["ccId"].Value.ToString().Trim()) ? 0 : Convert.ToInt32(row.Cells["ccId"].Value),
                        Amount = string.IsNullOrEmpty(row.Cells["ccAmount"].Value.ToString().Trim()) ? 0 : Convert.ToDouble(row.Cells["ccAmount"].Value)
                    };
                    if (cons.Id == 0 || cons.TypeId == 0 || cons.Amount < 0.01 || string.IsNullOrEmpty(cons.Comment)) throw new ArgumentException();
                    Conses.Add(cons);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Проверьте правильность ввода", Resources.Orders, MessageBoxButtons.OK);
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
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            var text = tbFind.Text.Trim();
            text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
            var conses = string.IsNullOrEmpty(text) ? Conses : Conses.Where(r => r.Comment.IndexOf(text) > -1).ToList();
            ConsLoad(conses);
        }

        #endregion
    }
}
