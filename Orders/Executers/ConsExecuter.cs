using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ConsExecuter : BaseExecuter<ECons, ECons>
    {
        public ConsExecuter(IExecuter executer) : base(executer){ }
        public ConsExecuter(IOrderContext context) : base(context){ }
        public ConsExecuter() { }

        public IEnumerable<ECons> GetPeriodConses(DatePeriod period)
        {
            return GetAll(w => w.date >= period.SqlStart && w.date < period.SqlEnd)
                .Include(r => r.Work).Include(r => r.Work.Type).Include(r => r.Type).OrderBy(r => r.date);
        }
    }
}