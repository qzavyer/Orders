using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class BackupLogExecuter : BaseExecuter<BackupLog, BackupLog>
    {
        public BackupLogExecuter(IExecuter executer) : base(executer) { }
        public BackupLogExecuter(IOrderContext context) : base(context) { }
        public BackupLogExecuter() { }

        public void ClearErrors()
        {

        }
    }
}