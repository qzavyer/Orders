using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class WorkExecuter : IContextable
    {
        public WorkExecuter(IOrderContext context)
        {
            Context = context;
        }

        public WorkExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<EWork> GetDuty()
        {
            return Context.Works.Where(r => r.Duty > 0)
                .Include(r => r.Type).Include(r => r.Client)
                .OrderBy(r=>r.datePay);
        }

        public IOrderContext Context { get; }
    }
}