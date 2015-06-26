using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Orders
{
    public partial class FrEvents : Form
    {
        private static readonly OrderContext DbContext = new OrderContext();
        public FrEvents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrEvents_Load(object sender, EventArgs e)
        {
            const string evCmd = "SELECT date(W.fDate,'unixepoch'), C.fName, T.fName " +
            "FROM tWork W JOIN tClient C ON W.fClientId=C.fId JOIN tWorkType T ON W.fTypeId=T.fId " +
            "WHERE CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)>=CAST(strftime('%j', :date1) AS INTEGER) AND " +
            "CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)<CAST(strftime('%j', :date2) AS INTEGER)";
            var conn = new SQLiteConnection(DbContext.Database.Connection.ConnectionString);
            using(var evCom = new SQLiteCommand(evCmd, conn)){
                var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                evCom.Parameters.AddWithValue("date1", start);
                evCom.Parameters.AddWithValue("date2", start.AddDays(7));
                evCom.Prepare();
                using (var evDr = evCom.ExecuteReader())
                {
                    var i = 0;
                    while (evDr.Read())
                    {
                        var l = new Label();
                        l.Parent = list;
                        l.Text = string.Format("{0}: {1} {2:dd.MM.yyyy}", evDr[1], evDr[2], evDr[3]);
                        l.Top = i*20+5;
                        l.Left = 5;
                    }
                }
            }

        }
    }
}
