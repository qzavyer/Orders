﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;

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

        public static List<Work> GetMonthWork(int month, int year)
        {
            var sDate = new DateTime(year, month, 1);
            var eDate = sDate.AddMonths(1);
            var conn = Connections.GetConnection();
            var lst = new List<Work>();
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS Id,W.fClientId AS ClientId,Wt.fId AS Type," +
                                     "date(W.fDate, 'unixepoch') AS Date," +
                                     "W.fPrepay AS Prepay," +
                                     "W.fExcess AS Excess,W.fHours AS Hours,S.fId AS Source," +
                                     "SUM(CASE WHEN Cs.fAmount IS NULL THEN 0 ELSE Cs.fAmount END) AS Cons," +
                                     "W.fSertId AS Sert,C.fName AS Client,date(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "P.fName AS PayerName " +
                                     "FROM tWork W " +
                                     "JOIN tClient C ON W.fClientId=C.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId " +
                                     "JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "LEFT JOIN tSert Sr ON Sr.fId=W.fSertId " +
                                     "LEFT JOIN tClient P ON Sr.fPayId=P.fId " +
                                     "LEFT JOIN tCons Cs ON Cs.fWorkId=W.fId AND Cs.fCertCons=0 " +
                                     "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end) " +
                                     "GROUP BY Id,ClientId,Type,Date,Prepay,Excess,Hours,Source,Sert,Client,ExDate," +
                                     "PayerName " +
                                     "ORDER BY Date,Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                wkCom.Parameters.AddWithValue("start", sDate);
                wkCom.Parameters.AddWithValue("end", eDate);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);

                lst.AddRange(from DataRow row in wkTable.Rows select new Work(row));
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