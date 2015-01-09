using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void FrClient_Load(object sender, EventArgs e)
        {
            var conn = Connections.GetConnection();
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
            }
            finally
            {
                conn.Close();
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var row = grClient.SelectedRows[0];
            ClientName.Id = Convert.ToInt32(row.Cells[0].Value);
            ClientName.Name = row.Cells[1].Value.ToString();
            Close();
        }
    }
}
