using System;
using System.Windows.Forms;
using Orders.Executers;

namespace Orders.Forms
{
    public partial class FrEvents : Form
    {
        public FrEvents()
        {
            var workExecuter = new WorkExecuter();
            var heroes = workExecuter.GetHeroes();
            var i = 0;
            foreach (var hero in heroes)
            {
                new Label
                {
                    Parent = list,
                    Text = $"{hero.Name}: {hero.Type} {hero.Date:dd.MM.yyyy}",
                    Top = i * 20 + 5,
                    Left = 5,
                    AutoSize = true
                };
                i++;
            }
            ItemCount = i;
            /*using (var dbContext = new OrderContext())
            {
                InitializeComponent();
                const string evCmd = "SELECT date(W.fDate,'unixepoch'), C.fName, T.fName " +
                "FROM tWork W JOIN tClient C ON W.fClientId=C.fId JOIN tWorkType T ON W.fTypeId=T.fId " +
                "WHERE CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)>=CAST(strftime('%j', :date1) AS INTEGER) AND " +
                "CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)<CAST(strftime('%j', :date2) AS INTEGER)";

                var conn = new SQLiteConnection(dbContext.Database.Connection.ConnectionString);
                conn.Open();
                using (var evCom = new SQLiteCommand(evCmd, conn))
                {
                    var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    evCom.Parameters.AddWithValue("date1", start);
                    evCom.Parameters.AddWithValue("date2", start.AddDays(7));
                    evCom.Prepare();
                    using (var evDr = evCom.ExecuteReader())
                    {
                        var i = 0;
                        while (evDr.Read())
                        {
                            var date = Convert.ToDateTime(evDr[0].ToString());
                            var name = evDr[1].ToString();
                            var type = evDr[2].ToString();
                            if(date.Year==DateTime.Now.Year) continue;
                            new Label
                            {
                                Parent = list,
                                Text = $"{name}: {type} {date:dd.MM.yyyy}",
                                Top = i * 20 + 5,
                                Left = 5,
                                AutoSize = true
                            };
                            i++;
                        }
                        ItemCount = i;
                    }
                }
            }//*/
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
