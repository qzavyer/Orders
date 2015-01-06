using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public static class Errors
    {
        public static void SaveError(string errorMessage, string function)
        {
            var conn = Connections.GetConnection();
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
