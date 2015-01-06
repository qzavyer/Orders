using System.Data.SQLite;

namespace Orders
{
    public static class Connections
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=order.db; Version=3;");
        }

        
    }
}
