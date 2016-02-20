using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Executers;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
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
            if (row == null) return;
            WorkType = new EWorkType { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }

        private void FilterTypes()
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = Regex.Replace(text, " +", " ");
                var typeExecuter = new WorkTypeExecuter();
                var types = typeExecuter.GetFilteredTypes(text).ToList();
                grWorkTypes.DataSource = types;
                btAdd.Enabled = grWorkTypes.RowCount == 0 && !string.IsNullOrEmpty(text);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var text = tbFind.Text.Trim();
                text = Regex.Replace(text, " +", " ");
                if (string.IsNullOrEmpty(text)) return;
                var typeExecuter = new WorkTypeExecuter();
                typeExecuter.Add(new EWorkType { Name = text });
                typeExecuter.Context.Save();
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
                var typeExecuter = new WorkTypeExecuter();
                foreach (DataGridViewRow row in grWorkTypes.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Id"].Value.ToString())) continue;
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = Regex.Replace(name, " +", " ");
                    typeExecuter.Update(new EWorkType { Name = name, Id = Convert.ToInt32(row.Cells["Id"].Value) });
                }
                typeExecuter.Context.Save();
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

        #endregion
    }
}
