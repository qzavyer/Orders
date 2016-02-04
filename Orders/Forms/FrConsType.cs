using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
{
    public partial class FrConsType : Form
    {
        #region Поля класса

        public EConsType ConsType;

        #endregion

        #region Управление формой
        
        public FrConsType()
        {
            InitializeComponent();
        }

        private void FrConsType_Load(object sender, EventArgs e)
        {
            if (ConsType != null) tbFind.Text = ConsType.Name;
            FilterTypes();
            var cId = grConsTypes.Columns["Id"];
            if (cId != null)
            {
                cId.Visible = false;
                cId.ReadOnly = true;
            }
            var cName = grConsTypes.Columns["Name"];
            if (cName != null)
            {
                cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cName.HeaderText = Resources.Cons_Type;
            }
            var ccons = grConsTypes.Columns["certCons"];
            if (ccons != null)
            {
                ccons.Visible = false;
            }
            var cCons = grConsTypes.Columns["IsCertCons"];
            if (cCons != null)
            {
                cCons.Visible = false;
                cCons.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                cCons.HeaderText = Resources.Cert;
            }
        }

        #endregion
        
        #region Работа формы
        
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTypes();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            using (var dbContext = new OrderContext())
            {
                try
                {
                    var text = tbFind.Text.Trim();
                    text = Regex.Replace(text, " +", " ");
                    if (string.IsNullOrEmpty(text)) return;
                    dbContext.ConsTypes.Add(new EConsType { Name = text });
                    dbContext.SaveChanges();
                    FilterTypes();
                }
                catch (Exception exception)
                {
                    ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                }
            }
        }
        private void FilterTypes()
        {
            using (var dbContext = new OrderContext())
            {
                try
                {
                    var text = tbFind.Text.Trim();
                    text = Regex.Replace(text, " +", " ");
                    var types = dbContext.ConsTypes.ToList();
                    if (!string.IsNullOrEmpty(text))
                    {
                        types = types.Where(r =>
                            r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
                    }
                    types.Sort(
                        (item1, item2) => String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
                    grConsTypes.DataSource = types;
                    btAdd.Enabled = grConsTypes.RowCount == 0 && !string.IsNullOrEmpty(text);
                }
                catch (Exception exception)
                {
                    ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                }
            }
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grConsTypes.SelectedRows[0];
            if (row == null) return;
            ConsType = new EConsType { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new OrderContext())
            {
                try
                {
                    foreach (DataGridViewRow row in grConsTypes.Rows)
                    {
                        if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                        var consType = dbContext.ConsTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
                        var name = row.Cells["Name"].Value.ToString().Trim();
                        name = Regex.Replace(name, " +", " ");
                        var cell = row.Cells["IsCertCons"];
                        var ch = (row.Cells["IsCertCons"] as DataGridViewCheckBoxCell);
                        if (ch != null)
                        {
                            var chVal = Convert.ToBoolean(cell.Value);
                            consType.IsCertCons = chVal;
                        }
                        else
                        {
                            consType.IsCertCons = false;
                        }
                        consType.Name = name;
                    }
                    dbContext.SaveChanges();
                    FilterTypes();
                    MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
                }
                catch (Exception exception)
                {
                    ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                    tbFind.Clear();
                    FilterTypes();
                }
            }
        }

        #endregion
    }
}
