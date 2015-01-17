using System;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrClient : Form
    {
        public readonly Client ClientName;
        public FrClient()
        {
            ClientName = new Client();
            InitializeComponent();
        }

        private void LoadClients()
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var clients = new DataTable();
                const string clCmd = "SELECT fId,fName,fPhone,fEmail,fNote " +
                                     "FROM tClient ORDER BY fName";
                var clAd = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(clCmd, conn) };
                clAd.Fill(clients);
                grClient.DataSource = clients;
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrClient_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grClient.SelectedRows[0];
            ClientName.Id = Convert.ToInt32(row.Cells[0].Value);
            ClientName.Name = row.Cells[1].Value.ToString();
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tClient (fName,fPhone,fEmail,fNote,fDate) " +
                                      "VALUES(:name,:phone,:mail,:note,strftime('%s',date('now')))";
                const string updCmd = "UPDATE tClient SET fName=:name,fPhone=:phone,fEmail=:mail,fNote=:note WHERE fId=:id";
                for (var i = 0; i < grClient.RowCount - 1; i++)
                {
                    var insCom = new SQLiteCommand(conn);
                    insCom.Parameters.Add(new SQLiteParameter("name", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("phone", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("mail", DbType.String));
                    insCom.Parameters.Add(new SQLiteParameter("note", DbType.String));
                    if (string.IsNullOrEmpty(grClient.Rows[i].Cells["fId"].Value.ToString()))
                    {
                        insCom.CommandText = insCmd;
                    }
                    else
                    {
                        insCom.CommandText = updCmd;
                        insCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        insCom.Parameters["id"].Value = grClient.Rows[i].Cells["fId"].Value;
                    }
                    insCom.Parameters["name"].Value = grClient.Rows[i].Cells["fName"].Value.ToString();
                    insCom.Parameters["phone"].Value = grClient.Rows[i].Cells["fPhone"].Value.ToString();
                    insCom.Parameters["mail"].Value = grClient.Rows[i].Cells["fEmail"].Value.ToString();
                    insCom.Parameters["note"].Value = grClient.Rows[i].Cells["fNote"].Value.ToString();
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                LoadClients();
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
