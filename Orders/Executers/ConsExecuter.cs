using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ConsExecuter: IContextable
    {
        public ConsExecuter(IOrderContext context)
        {
            Context = context;
        }

        public ConsExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<ECons> GetPeriodConses(DatePeriod period)
        {
            return Context.Conses.Where(w => w.date >= period.SqlStart && w.date < period.SqlEnd)
                .Include(r => r.Work).Include(r => r.Work.Type).Include(r => r.Type).OrderBy(r => r.date);
        }

        public IOrderContext Context { get; }
    }
}