using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Executers;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
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
            try
            {
                var typeExecuter = new SourceTypeExecuter();
                var text = tbFind.Text.Trim();
                text = Regex.Replace(text, " +", " ");
                var types = typeExecuter.GetFilteredTypes(text);
                grSources.DataSource = types;
                btAdd.Enabled = grSources.RowCount == 0 && !string.IsNullOrEmpty(text);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var typeExecuter = new SourceTypeExecuter();
            try
            {
                var text = tbFind.Text.Trim();
                text = Regex.Replace(text, " +", " ");
                if (string.IsNullOrEmpty(text)) return;
                typeExecuter.Add(new ESourceType {Name = text});
                typeExecuter.Save();
                FilterTypes();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var typeExecuter = new SourceTypeExecuter();
                foreach (DataGridViewRow row in grSources.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString())) continue;
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = Regex.Replace(name, " +", " ");
                    typeExecuter.Update(new ESourceType {Id = Convert.ToInt32(row.Cells["Id"].Value), Name = name});
                }
                typeExecuter.Save();
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
}
