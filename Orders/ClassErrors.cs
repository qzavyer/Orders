using System.Data;
using System.Windows.Forms;
using Orders.Properties;
using System.Data.SQLite;

namespace Orders
{
    public static class Errors
    {
        private static readonly OrderContext Db = new OrderContext();

        public static void SaveError(string errorMessage, string function)
        {
            var conn = new SQLiteConnection(Db.Database.Connection.ConnectionString);
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tError (fDate,fError,fFunc) " +
                                      "VALUES(strftime('%s', 'now'),:error,:func)";
                var insCom = new SQLiteCommand(insCmd, conn);
                insCom.Parameters.Add(new SQLiteParameter("error", DbType.String));
                insCom.Parameters.Add(new SQLiteParameter("func", DbType.String));
                insCom.Parameters["error"].Value = errorMessage;
                insCom.Parameters["func"].Value = function;
                insCom.Prepare();
                insCom.ExecuteNonQuery();
                MessageBox.Show(errorMessage, Resources.Error, MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
