using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrSource : Form
    {
        private static readonly OrderContext Db = new OrderContext();
        public ESourceType Source;

        public FrSource()
        {
            InitializeComponent();
        }

        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTypes();
        }

        private void FrSource_Load(object sender, EventArgs e)
        {
            var types = Db.SourceTypes.ToList();
            types.Sort((item1, item2) => String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
            grSources.DataSource = types;
            var cId = grSources.Columns["Id"];
            if (cId != null)
            {
                cId.Visible = false;
                cId.ReadOnly = true;
            }
            var cName = grSources.Columns["Name"];
            if (cName != null)
            {
                cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cName.HeaderText = Resources.Source;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grSources.SelectedRows[0];
            if (row == null) return;
            Source = new ESourceType { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }

        private void FilterTypes()
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
                var types = Db.SourceTypes.ToList();
                if (!string.IsNullOrEmpty(text))
                {
                    types = types.Where(r =>
                        r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
                }
                types.Sort(
                    (item1, item2) => String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase));
                grSources.DataSource = types;
                btAdd.Enabled = grSources.RowCount == 0 && !string.IsNullOrEmpty(text);
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
                if (string.IsNullOrEmpty(text)) return;
                Db.SourceTypes.Add(new ESourceType { Name = text });
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
                foreach (DataGridViewRow row in grSources.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                    var workType = Db.SourceTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
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
