using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Orders
{
    public class DbColumn
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool NotNull { get; set; }
        public string Default { get; set; }
        public bool Pk { get; set; }

        public DbColumn(string name, string type, bool notNull = false, string def = null, bool pk = false)
        {
            Name = name;
            Type = type;
            NotNull = notNull;
            Default = def;
            Pk = pk;
        }
    }
    public class DbTable
    {
        public string Name { get; set; }
        public string Ddl { get; set; }
        public List<DbColumn> Columns { get; set; } 
    }

    public static class DbCheck
    {
        public static void CheckDatabase()
        {
            var dbContext = new OrderContext();
                
            var conn = new SQLiteConnection(dbContext.Database.Connection.ConnectionString);
            try
            {
                conn.Open();

                var tables = new List<DbTable>();
                tables.Add(new DbTable
                {
                    Name = "tTest",
                    Ddl = "CREATE TABLE \"tTest\" (\"fId\"  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                          "\"fName\"  TEXT NOT NULL,\"fPhone\"  TEXT,\"fEmail\"  TEXT,\"fNote\"  TEXT," +
                          "\"fDate\"  INTEGER NOT NULL DEFAULT 0);",
                    Columns = new List<DbColumn>
                    {
                        new DbColumn("fId", "INTEGER"),
                        new DbColumn("fName", "TEXT"),
                        new DbColumn("fPhone", "TEXT"),
                        new DbColumn("fEmail", "TEXT"),
                        new DbColumn("fNote", "TEXT"),
                        new DbColumn("fDate", "INTEGER")
                    }
                });

                foreach (var table in tables)
                {
                    var cmd1 = "PRAGMA table_info('"+table.Name+"')";
                    var comq = new SQLiteCommand(cmd1, conn);
                    /*comq.Parameters.Add("name", DbType.String).Value = table.Name;
                    comq.Prepare();*/
                    var d = comq.ExecuteReader();
                    if (d.HasRows)
                    {
                        var list = new List<DbColumn>();
                        while (d.Read())
                        {
                            list.Add(new DbColumn(d["name"].ToString(), d["type"].ToString(),
                                Convert.ToInt32(d["notnull"]) == 1, null, Convert.ToInt32(d["pk"]) == 1));
                        }
                        foreach (var column in table.Columns)
                        {
                            if (list.Any(r => r.Name == column.Name))
                            foreach (var item in list.Where(r=>r.Name==column.Name))
                            {
                                if (item.Type != column.Type)
                                {
                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        d.Close();
                        var comcreate = new SQLiteCommand(table.Ddl, conn);
                        comcreate.ExecuteNonQuery();
                    }
                }


                const string cmd = "SELECT COUNT(*) FROM \"tWork\"";
                var com = new SQLiteCommand(cmd, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
