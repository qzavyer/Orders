using System;
using System.Data.SQLite;
using System.Reflection;
using Orders.Classes;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class DataBaseExecuter
    {
        private readonly IOrderContext _context;

        public DataBaseExecuter()
        {
            _context = new OrderContext();
        }

        public bool CheckDatabase()
        {
            try
            {
                var connStr = _context.ConnectionString;
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    const string cmd = "SELECT COUNT(*) FROM \"tWork\"";
                    var com = new SQLiteCommand(cmd, conn);
                    com.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            try
            {
                var connStr = _context.ConnectionString;
                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    var t = conn.BeginTransaction();
                    var com = new SQLiteCommand("CREATE TABLE \"tClient\"(\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                                "NOT NULL,\"fName\" TEXT NOT NULL,\"fPhone\" TEXT,\"fEmail\" TEXT," +
                                                "\"fNote\" TEXT,\"fDate\" INTEGER NOT NULL DEFAULT 0);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tCons\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                            "NOT NULL,\"fTypeId\" INTEGER NOT NULL,\"fAmount\" REAL NOT NULL " +
                                            "DEFAULT 0,\"fDate\" INTEGER NOT NULL,\"fComment\" TEXT,\"fCertCons\" " +
                                            "INTEGER NOT NULL DEFAULT 0,\"fWorkId\" INTEGER,\"fCertId\" INTEGER," +
                                            "\"fIsCert\" INTEGER NOT NULL DEFAULT 0," +
                                            "CONSTRAINT \"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES \"tConsType\" " +
                                            "(\"fId\") ON UPDATE RESTRICT);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tConsType\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                            "NOT NULL,\"fName\" TEXT NOT NULL,\"fCertCons\" INTEGER NOT NULL " +
                                            "DEFAULT 0);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tError\"(\"fDate\" INTEGER NOT NULL,\"fError\" TEXT NOT " +
                                            "NULL,\"fFunc\"  TEXT);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tSource\"(\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT " +
                                            "NULL,\"fName\"  TEXT NOT NULL);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tWorkType\"(\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT " +
                                            "NOT NULL,\"fName\" TEXT NOT NULL);", conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tSert\"(\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT " +
                                            "NULL,\"fPayId\" INTEGER NOT NULL,\"fClientId\" INTEGER NOT NULL," +
                                            "\"fTypeId\" INTEGER NOT NULL,\"fDatePay\" INTEGER NOT NULL," +
                                            "\"fDateEnd\" INTEGER NOT NULL,\"fPrice\" REAL NOT NULL DEFAULT 0," +
                                            "\"fHours\" REAL NOT NULL DEFAULT 0,\"fCash\" INTEGER NOT NULL DEFAULT " +
                                            "0,\"fSource\" INTEGER NOT NULL,\"fConsed\" REAL NOT NULL DEFAULT 0," +
                                            "CONSTRAINT \"Sourse\" FOREIGN KEY (\"fSource\") REFERENCES \"tSource\" " +
                                            "(\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Client\" FOREIGN KEY " +
                                            "(\"fClientId\") REFERENCES \"tClient\" (\"fId\") ON UPDATE RESTRICT," +
                                            "CONSTRAINT \"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES \"tWorkType\" " +
                                            "(\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Payer\" FOREIGN KEY " +
                                            "(\"fPayId\") REFERENCES \"tClient\" (\"fId\") ON UPDATE RESTRICT);", 
                                            conn);
                    com.ExecuteNonQuery();
                    com = new SQLiteCommand("CREATE TABLE \"tWork\" (\"fId\" INTEGER PRIMARY KEY AUTOINCREMENT NOT " +
                                            "NULL,\"fClientId\" INTEGER NOT NULL,\"fTypeId\" INTEGER NOT NULL," +
                                            "\"fDate\" INTEGER NOT NULL,\"fPrepay\" REAL NOT NULL DEFAULT 0," +
                                            "\"fExcess\" REAL NOT NULL DEFAULT 0,\"fHours\" REAL NOT NULL DEFAULT 0," +
                                            "\"fSourceId\" INTEGER NOT NULL,\"fSertId\" INTEGER,\"fExcessDate\" " +
                                            "INTEGER,\"fDuty\" REAL NOT NULL DEFAULT 0,CONSTRAINT \"Client\" " +
                                            "FOREIGN KEY (\"fClientId\") REFERENCES \"tClient\" (\"fId\") ON UPDATE " +
                                            "RESTRICT,CONSTRAINT \"Type\" FOREIGN KEY (\"fTypeId\") REFERENCES " +
                                            "\"tWorkType\" (\"fId\") ON UPDATE RESTRICT,CONSTRAINT \"Source\" " +
                                            "FOREIGN KEY (\"fSourceId\") REFERENCES \"tSource\" (\"fId\") ON UPDATE " +
                                            "RESTRICT,CONSTRAINT \"Sert\" FOREIGN KEY (\"fSertId\") REFERENCES " +
                                            "\"tSert\" (\"fId\") ON UPDATE RESTRICT);", conn);
                    com.ExecuteNonQuery();
                    t.Commit();
                }
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }
    }
}