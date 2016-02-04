using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
{
    public partial class FrAddClient : Form
    {
        public FrAddClient()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            using (var dbContext = new OrderContext())
            {
                try
                {
                    var name = tbName.Text.Trim();
                    name = Regex.Replace(name, " +", " ");
                    var phone = tbPhone.Text.Trim();
                    phone = Regex.Replace(phone, " +", " ");
                    var mail = tbMail.Text.Trim();
                    mail = Regex.Replace(mail, " +", " ");
                    var note = tbNote.Text.Trim();
                    note = Regex.Replace(note, " +", " ");
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show(Resources.NotEmptyName, Resources.Orders, MessageBoxButtons.OK);
                        return;
                    }
                    var client = new EClient
                    {
                        Name = name,
                        Phone = phone,
                        Mail = mail,
                        Note = note
                    };
                    dbContext.Clients.Add(client);
                    dbContext.SaveChanges();
                    Close();
                }
                catch (Exception exception)
                {
                    ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrAddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            tbName.Clear();
            tbPhone.Clear();
            tbMail.Clear();
            tbNote.Clear();
        }

        private void FrAddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
