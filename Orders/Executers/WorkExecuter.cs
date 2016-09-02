using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using Orders.Classes;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class WorkExecuter : BaseExecuter<EWork, EWork>
    {
        public WorkExecuter(IExecuter executer) : base(executer){ }
        public WorkExecuter(IOrderContext context) : base(context){ }
        public WorkExecuter() { }

        public IEnumerable<Hero> GetHeroes()
        {
            var list = new List<Hero>();
            const string evCmd = "SELECT date(W.fDate,'unixepoch') AS \"date\", C.fName AS \"name\", T.fName AS \"type\"" +
                "FROM tWork W JOIN tClient C ON W.fClientId=C.fId JOIN tWorkType T ON W.fTypeId=T.fId " +
                "WHERE CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)>=CAST(strftime('%j', :date1) AS INTEGER) AND " +
                "CAST(strftime('%j',date(W.fDate,'unixepoch')) AS INTEGER)<CAST(strftime('%j', :date2) AS INTEGER)";

            var conn = new SQLiteConnection(Context.ConnectionString);
            conn.Open();
            using (var evCom = new SQLiteCommand(evCmd, conn))
            {
                var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                evCom.Parameters.AddWithValue("date1", start);
                evCom.Parameters.AddWithValue("date2", start.AddDays(7));
                evCom.Prepare();
                using (var evDr = evCom.ExecuteReader())
                {
                    while (evDr.Read())
                    {
                        var date = Convert.ToDateTime(evDr["date"].ToString());
                        var name = evDr["name"].ToString();
                        var type = evDr["type"].ToString();
                        if (date.Year == DateTime.Now.Year) continue;
                        list.Add(new Hero {Date = date, Name = name, Type = type});
                    }
                }
            }
            return list;
        }

        public IEnumerable<EWork> GetDuty()
        {
            return GetAll(r => r.Duty > 0)
                .Include(r => r.Type).Include(r => r.Client)
                .OrderBy(r=>r.datePay);
        }

        public IEnumerable<EWork> GetPeriodWorks(DatePeriod period)
        {
            return GetAll(w => w.datePay >= period.SqlStart && w.datePay < period.SqlEnd)
                .Include(r => r.Client).Include(r => r.Conses).Include(r => r.Source).Include(r => r.Type);
        }

        public DateTime? GetMinDate()
        {
            if (!GetAll().Any()) return null;
            var mindate = GetAll().Min(r => r.datePay);
            if (mindate == 0) return null;
            return mindate.ToDateTime();
        }
    }
}