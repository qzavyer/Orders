using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrClient : Form
    {
        private static readonly OrderContext Db = new OrderContext();
        private static bool _hasChange;
        public Client ClientName;
        public FrClient()
        {
            //ClientName = new Client();
            InitializeComponent();
        }

        private void FrClient_Load(object sender, EventArgs e)
        {
            try
            {
                FilterClients();
                var cId = grClient.Columns["Id"];
                if (cId != null)
                {
                    cId.Visible = false;
                    cId.ReadOnly = true;
                }
                var cName = grClient.Columns["Name"];
                if (cName != null)
                {
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cName.HeaderText = Resources.Name;
                }
                var cPhone = grClient.Columns["Phone"];
                if (cPhone != null)
                {
                    cPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cPhone.Width = 120;
                    cPhone.HeaderText = Resources.Phone;
                }
                var cEmail = grClient.Columns["Mail"];
                if (cEmail != null)
                {
                    cEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cEmail.Width = 120;
                    cEmail.HeaderText = Resources.Email;
                }
                var cNote = grClient.Columns["Note"];
                if (cNote != null)
                {
                    cNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cNote.Width = 150;
                    cNote.HeaderText = Resources.Note;
                }
                _hasChange = false;
            }
            catch(Exception exception)
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
            if (_hasChange)
            {
                var svResult = MessageBox.Show(Resources.ChangeData, Resources.Orders, MessageBoxButtons.YesNo);
                if (svResult == DialogResult.Yes)
                {
                    SaveChanges();
                }
                return;
            }
            var row = grClient.SelectedRows[0];
            if (row == null) return;
            ClientName = new Client { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
           FilterClients();
        }

        private void FilterClients()
        {
            var text = tbFind.Text.Trim();
            text = System.Text.RegularExpressions.Regex.Replace(text, " +", " ");
            var clients = Db.Clients.ToList();
            if (!string.IsNullOrEmpty(text))
                clients = clients.Where(r => r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList(); 
            clients.Sort((item1, item2) =>
            {
                var order1 = item1.Date.CompareTo(item2.Date);
                return order1 == 0 ? String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) : order1;
            });
            grClient.DataSource = clients;
        }

        private void grClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
        }

        private void SaveChanges()
        {
            try
            {
                foreach (DataGridViewRow row in grClient.Rows)
                {
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = System.Text.RegularExpressions.Regex.Replace(name, " +", " ");
                    var phone = row.Cells["Phone"].Value.ToString().Trim();
                    phone = System.Text.RegularExpressions.Regex.Replace(phone, " +", " ");
                    var mail = row.Cells["Email"].Value.ToString().Trim();
                    mail = System.Text.RegularExpressions.Regex.Replace(mail, " +", " ");
                    var note = row.Cells["Note"].Value.ToString().Trim();
                    note = System.Text.RegularExpressions.Regex.Replace(note, " +", " ");
                    if (!string.IsNullOrEmpty(row.Cells["Id"].Value.ToString().Trim()))
                    {
                        var client = Db.Clients.Find(Convert.ToInt32(row.Cells["Id"].Value));
                        client.Name = name;
                        client.Phone = phone;
                        client.Mail = mail;
                        client.Note = note;
                    }
                    else
                    {
                        Db.Clients.Add(new EClient
                        {
                            Name = name,
                            Phone = phone,
                            Mail = mail,
                            Note = note
                        });
                    }
                }
                Db.SaveChanges();
                _hasChange = false;
                var clients = grClient.DataSource as DataTable;
                if (clients != null) clients.DefaultView.RowFilter = null;
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
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var fr = new FrAddClient();
            fr.tbName.Text = tbFind.Text;
            fr.ShowDialog();
            FilterClients();
        }
    }
}
