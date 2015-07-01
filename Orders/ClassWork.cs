using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Orders
{
    public class ClassWork
    {
        public static List<ModelStat> GetYearStat(int year)
        {
            var lst = new List<ModelStat>();
            for (var i = 1; i <= 12; i++)
            {
                lst.Add(new ModelStat { Month = i });
            }
            var sDate = new DateTime(year, 1, 1);
            var eDate = new DateTime(year + 1, 1, 1);
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                const string wkCmd = "SELECT date(W.fDate, 'unixepoch') AS Date,W.fHours AS Hours," +
                                     "(W.fPrepay+W.fExcess) AS Price," +
                                     "SUM(CASE WHEN C.fAmount IS NULL THEN 0 ELSE C.fAmount END) AS Cons " +
                                     "FROM tWork W LEFT JOIN tCons C ON W.fId=C.fWorkId " +
                                     "WHERE W.fDate>=strftime('%s',:start) AND " +
                                     "W.fDate<strftime('%s',:end) " +
                                     "GROUP BY Date,Hours,Price";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                wkCom.Parameters.AddWithValue("start", sDate);
                wkCom.Parameters.AddWithValue("end", eDate);
                wkCom.Prepare();
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                
                foreach (DataRow row in wkTable.Rows)
                {
                    var a = row["Date"].ToString();
                    var b = a;
                    var month = Convert.ToDateTime(row["Date"]).Month;
                    foreach (var stat in lst.Where(s=>s.Month==month))
                    {
                        stat.Income = stat.Income + Convert.ToDouble(row["Price"]);
                        stat.Hours = stat.Hours + Convert.ToDouble(row["Hours"]);
                        stat.Cons = stat.Cons + Convert.ToDouble(row["Cons"]);
                    }
                }

                const string cnsCmd = "SELECT date(fDate, 'unixepoch') AS Date,fAmount AS Cons " +
                                     "FROM tCons " +
                                     "WHERE date(fDate, 'unixepoch')>=:start AND " +
                                     "date(fDate, 'unixepoch')<:end AND fWorkId=0";
                var cnsCom = new SQLiteCommand(cnsCmd, conn);
                cnsCom.Parameters.AddWithValue("start", sDate);
                cnsCom.Parameters.AddWithValue("end", eDate);
                cnsCom.Prepare();
                var cnsTable = new DataTable();
                var cnsAdapt = new SQLiteDataAdapter(cnsCom);
                cnsAdapt.Fill(cnsTable);
                foreach (DataRow row in cnsTable.Rows)
                {
                    var month = Convert.ToDateTime(row["Date"]).Month;
                    foreach (var stat in lst.Where(s => s.Month == month))
                    {
                        stat.Cons = stat.Cons + Convert.ToDouble(row["Cons"]);
                    }
                }
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
            return lst;
        } 
    }
}
