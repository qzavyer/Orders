using System;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;
using NLog;
using Orders.Classes.Exceptions;
using Orders.Executers;
using Orders.Properties;

namespace Orders.Classes
{
    public class ErrorSaver
    {
        private static ErrorSaver _saver;
        private Exception _lastException;
        Logger loger = LogManager.GetCurrentClassLogger();

        private ErrorSaver()
        {

        }

        public static ErrorSaver GetInstance()
        {
            return _saver ?? (_saver = new ErrorSaver());
        }

        public void HandleError(MethodBase methodBase, Exception exception)
        {

            var currentException = exception.GetType() == typeof(HandledException)
                ? exception.InnerException
                : exception;
            if (_lastException == currentException) return;
            if (currentException.GetType() == typeof(WorkException)) return;
            loger.Fatal(currentException);
            //var declaringType = methodBase?.DeclaringType;
            //if (declaringType == null) return;
            //var cName = declaringType.Name;
            //var mName = methodBase.Name;
            //SaveError(cName + "/" + mName, exception);
            _lastException = currentException;
        }

        private static void SaveError(string funcName, Exception exception)
        {
            var errorExecuter = new ErrorExecuter();
            using (var conn = new SQLiteConnection(errorExecuter.GetConnectionString()))
            {
                var message = GetInnerException(exception);
                conn.Open();
                const string insCmd = "INSERT INTO tError (fDate,fError,fFunc) " +
                                      "VALUES(strftime('%s', 'now'),:error,:func)";
                var insCom = new SQLiteCommand(insCmd, conn);
                insCom.Parameters.Add("error", DbType.String).Value = message;
                insCom.Parameters.Add("func", DbType.String).Value = funcName;
                insCom.Prepare();
                insCom.ExecuteNonQuery();
                MessageBox.Show(message, Resources.Error, MessageBoxButtons.OK);
            }
        }

        private static string GetInnerException(Exception exception)
        {
            var msg = exception.Message;
            if (exception.InnerException != null)
            {
                msg = msg + "(" + GetInnerException(exception.InnerException) + ")";
            }
            return msg;
        }
    }
}