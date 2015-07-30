using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrWorkType : Form
    {
        #region Поля класса
        
        public EWorkType WorkType;
        
        #endregion

        #region Управление формой
        
        public FrWorkType()
        {
            InitializeComponent();
        }

        private void FrWorkType_Load(object sender, EventArgs e)
        {
            if (WorkType != null)
                tbFind.Text = WorkType.Name;
            FilterTypes();
            var cId = grWorkTypes.Columns["Id"];
            if (cId != null)
            {
                cId.Visible = false;
                cId.ReadOnly = true;
            }
            var cName = grWorkTypes.Columns["Name"];
            if (cName != null)
            {
                cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cName.HeaderText = Resources.Work_Type;
            }
        }

        #endregion

        #region Работа формы

        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTypes();
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grWorkTypes.SelectedRows[0];
            if(row==null) return;
            WorkType = new EWorkType {Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString()};
            Close();
        }
        private void FilterTypes()
        {
            using (var db = new OrderContext())
            {
                try
                {
                    var text = tbFind.Text.Trim();
                    text = Regex.Replace(text, " +", " ");
                    var types = db.WorkTypes.ToList();
                    if (!string.IsNullOrEmpty(text))
                    {
                        types = types.Where(r =>
                            r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
                    }
                    types.Sort(
                        (item1, item2) => String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
                    grWorkTypes.DataSource = types;
                    btAdd.Enabled = grWorkTypes.RowCount == 0 && !string.IsNullOrEmpty(text);
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
        private void btAdd_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                try
                {
                    var text = tbFind.Text.Trim();
                    text = Regex.Replace(text, " +", " ");
                    if (string.IsNullOrEmpty(text)) return;
                    db.WorkTypes.Add(new EWorkType { Name = text });
                    db.SaveChanges();
                    FilterTypes();
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
        private void btSave_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                try
                {
                    foreach (DataGridViewRow row in grWorkTypes.Rows)
                    {
                        if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                        var workType = db.WorkTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
                        var name = row.Cells["Name"].Value.ToString().Trim();
                        name = Regex.Replace(name, " +", " ");
                        workType.Name = name;
                    }
                    db.SaveChanges();
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
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                    tbFind.Clear();
                    FilterTypes();
                }
            }
        }

        #endregion
    }
}
