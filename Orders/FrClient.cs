﻿using System;
using System.Data;
<<<<<<< HEAD
using System.Linq;
=======
using System.Data.SQLite;
>>>>>>> origin/Расход
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrClient : Form
    {
        #region Поля класса

        private static readonly OrderContext Db = new OrderContext();
        private static bool _hasChange;
        public EClient ClientName;

        #endregion

        #region Управление формой
        
        public FrClient()
        {
            //ClientName = new Client();
            InitializeComponent();
        }
<<<<<<< HEAD
        private void FrClient_Load(object sender, EventArgs e)
=======

        private void LoadClients()
>>>>>>> origin/Расход
        {
            try
            {
<<<<<<< HEAD
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
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cName.HeaderText = Resources.Name;
                }
                var cPhone = grClient.Columns["Phone"];
                if (cPhone != null)
                {
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cPhone.HeaderText = Resources.Phone;
                }
                var cEmail = grClient.Columns["Mail"];
                if (cEmail != null)
                {
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cEmail.HeaderText = Resources.Email;
                }
                var cNote = grClient.Columns["Note"];
                if (cNote != null)
                {
                    cNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cNote.HeaderText = Resources.Note;
                }

                var cDateP = grClient.Columns["idate"];
                if (cDateP != null)
                {
                    cDateP.Visible = false;
                }

                var cDate = grClient.Columns["Date"];
                if (cDate != null)
                {
                    cDate.Visible = false;
                }
                _hasChange = false;
=======
                conn.Open();
                var clients = new DataTable();
                const string clCmd = "SELECT fId,fName,fPhone,fEmail,fNote " +
                                     "FROM tClient ORDER BY fName";
                var clAd = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(clCmd, conn) };
                clAd.Fill(clients);
                grClient.DataSource = clients;
>>>>>>> origin/Расход
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

<<<<<<< HEAD
        #endregion

        #region Работа формы
=======
        private void FrClient_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
>>>>>>> origin/Расход

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
            ClientName = new EClient { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }
<<<<<<< HEAD
        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var fr = new FrAddClient();
            fr.tbName.Text = tbFind.Text;
            fr.ShowDialog();
            FilterClients();
        }
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterClients();
        }
        private void grClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
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
=======

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
>>>>>>> origin/Расход
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
<<<<<<< HEAD
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
                tbFind.Clear();
            }
        }

        #endregion
=======
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }
>>>>>>> origin/Расход
    }
}
