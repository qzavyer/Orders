using System;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrClient : Form
    {
        private static readonly OrderContext Db = new OrderContext();
        public Client ClientName=null;
        public FrClient()
        {
            //ClientName = new Client();
            InitializeComponent();
        }

        private void FrClient_Load(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection(Db.Database.Connection.ConnectionString);
            try
            {
                conn.Open();
                var clients = new DataTable();
                const string clCmd = "SELECT fId AS \"Id\",fName AS \"Name\", " +
                                     "fPhone AS \"Phone\", fEmail AS \"Email\",fNote AS \"Note\" " +
                                     "FROM tClient ORDER BY fName";
                var clAd = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(clCmd, conn)};
                clAd.Fill(clients);
                grClient.DataSource = clients;
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
                var cEmail = grClient.Columns["Email"];
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
                    cNote.HeaderText = Resources.Phone;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grClient.SelectedRows[0];
            if (row == null) return;
            ClientName = new Client { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
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
                FilterClients();
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

        private void FilterClients()
        {
            
        }
    }
}
