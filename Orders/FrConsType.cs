using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrConsType : Form
    {
        #region Поля класса

        private static readonly OrderContext DbContext = new OrderContext();
        public EConsType ConsType;

        #endregion

        #region Управление формой
        
        public FrConsType()
        {
            InitializeComponent();
        }
        private void FrConsType_Load(object sender, EventArgs e)
        {
            var types = DbContext.ConsTypes.OrderBy(r => r.Name).ToList();
            grConsTypes.DataSource = types;
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
        }

        #endregion
        
        #region Работа формы
        
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTypes();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
                if(string.IsNullOrEmpty(text))return;
                DbContext.ConsTypes.Add(new EConsType { Name = text });
                DbContext.SaveChanges();
                FilterTypes();
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
        }
        private void FilterTypes()
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
                var types = DbContext.ConsTypes.ToList();
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
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
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
            try
            {
                foreach (DataGridViewRow row in grConsTypes.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                    var consType = DbContext.ConsTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = System.Text.RegularExpressions.Regex.Replace(name, " +", " ");
                    consType.Name = name;
                }
                DbContext.SaveChanges();
                FilterTypes();
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
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
                tbFind.Clear();
                FilterTypes();
            }
        }

        #endregion
    }
}
