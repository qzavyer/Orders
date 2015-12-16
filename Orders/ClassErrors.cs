using System;
using System.Data;
using System.Windows.Forms;
using Orders.Properties;
using System.Data.SQLite;

namespace Orders
{
    public static class Errors
    {
        private static string GetInnerMessage(Exception error)
        {
            var msg = error.Message;
            if (error.InnerException != null)
            {
                msg = msg + "(" + GetInnerMessage(error.InnerException) + ")";
            }
            return msg;
        }

        public static void SaveError(Exception error, string function)
        {
            var errorMessage = GetInnerMessage(error);
            var db = new OrderContext();
            var conn = new SQLiteConnection(db.Database.Connection.ConnectionString);
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
