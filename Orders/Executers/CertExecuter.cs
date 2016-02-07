using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class CertExecuter : IContextable
    {
        public CertExecuter(IOrderContext context)
        {
            Context = context;
        }

        public CertExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<ECert> GetPeriodCerts(DatePeriod period)
        {
            return Context.Certs.Where(w => w.datePay >= period.SqlStart && w.datePay < period.SqlEnd)
                .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                .OrderBy(r => r.datePay);
        }

        public IEnumerable<ECert> GetUnworkedCerts(int? certId=null)
        {
            var workLst = Context.Works.Select(r => r.CertId).ToList();
            return Context.Certs.Where(w => !workLst.Contains(w.Id)||w.Id==certId)
                        .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                        .OrderBy(r => r.datePay);
        }

        public IOrderContext Context { get; }
    }
}