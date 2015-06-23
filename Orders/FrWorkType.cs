using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrWorkType : Form
    {
        private static readonly OrderContext Db = new OrderContext();
        public EWorkType WorkType;
        
        public FrWorkType()
        {
            InitializeComponent();
        }

        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTypes();
        }

        private void FrWorkType_Load(object sender, EventArgs e)
        {
            var types = Db.WorkTypes.ToList();
            types.Sort((item1,item2)=>String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
            grWorkTypes.DataSource = types;
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

        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grWorkTypes.SelectedRows[0];
            if(row==null) return;
            WorkType = new EWorkType {Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString()};
            Close();
        }

        private void FilterTypes()
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
                var types = Db.WorkTypes.ToList();
                if (!string.IsNullOrEmpty(text))
                {
                    types = types.Where(r =>
                        r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
                }
                types.Sort(
                    (item1, item2) => String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
                grWorkTypes.DataSource = types;
                btAdd.Enabled = grWorkTypes.RowCount == 0;
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
                Db.WorkTypes.Add(new EWorkType {Name = text});
                Db.SaveChanges();
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

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grWorkTypes.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                    var workType = Db.WorkTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = System.Text.RegularExpressions.Regex.Replace(name, " +", " ");
                    workType.Name = name;
                }
                Db.SaveChanges();
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
    }
}
