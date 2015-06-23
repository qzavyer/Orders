using System;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrAddClient : Form
    {
        private static readonly OrderContext DbContext = new OrderContext();
        public FrAddClient()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var name = tbName.Text.Trim();
            name = System.Text.RegularExpressions.Regex.Replace(name, " +", " ");
            var phone = tbPhone.Text.Trim();
            phone = System.Text.RegularExpressions.Regex.Replace(phone, " +", " ");
            var mail = tbMail.Text.Trim();
            mail = System.Text.RegularExpressions.Regex.Replace(mail, " +", " ");
            var note = tbNote.Text.Trim();
            note = System.Text.RegularExpressions.Regex.Replace(note, " +", " ");
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
            DbContext.Clients.Add(client);
            DbContext.SaveChanges();
            Close();
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
    }
}
