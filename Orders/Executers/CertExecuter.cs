using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class CertExecuter : BaseExecuter<ECert, ECert>
    {
        public CertExecuter(IExecuter executer) : base(executer){ }
        public CertExecuter(IOrderContext context) : base(context){ }
        public CertExecuter() { }

        public IEnumerable<ECert> GetPeriodCerts(DatePeriod period)
        {
            return GetAll(w => w.datePay >= period.SqlStart && w.datePay < period.SqlEnd)
                .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                .OrderBy(r => r.datePay);
        }

        public IEnumerable<ECert> GetUnworkedCerts(int? certId=null)
        {
            var workExecuter = new WorkExecuter(Context);
            var workLst = workExecuter.GetAll(r=>r.CertId!=null).Select(r => r.CertId).ToList();
            return GetAll(w => !workLst.Contains(w.Id)||w.Id==certId)
                        .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                        .OrderBy(r => r.datePay);
        }
    }
}