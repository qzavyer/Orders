using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrSource : Form
    {
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
            if (Source != null) tbFind.Text = Source.Name;
            FilterTypes();
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
            using (var db = new OrderContext())
            {
                try
                {
                    var text = tbFind.Text.Trim();
                    text = Regex.Replace(text, " +", " ");
                    var types = db.SourceTypes.ToList();
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
                    Errors.HandleError(MethodBase.GetCurrentMethod(), exception);
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
                    db.SourceTypes.Add(new ESourceType { Name = text });
                    db.SaveChanges();
                    FilterTypes();
                }
                catch (Exception exception)
                {
                    Errors.HandleError(MethodBase.GetCurrentMethod(), exception);
                }
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                try
                {
                    foreach (DataGridViewRow row in grSources.Rows)
                    {
                        if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Id"].Value.ToString())) continue;
                        var workType = db.SourceTypes.Find(Convert.ToInt32(row.Cells["Id"].Value));
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
                    Errors.HandleError(MethodBase.GetCurrentMethod(), exception);
                    tbFind.Clear();
                    FilterTypes();
                }
            }
        }
    }
}
