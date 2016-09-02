using System;
using System.Collections.Generic;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ClientExecuter : BaseExecuter<EClient, EClient>
    {
        public ClientExecuter(IExecuter executer) : base(executer){}
        public ClientExecuter(IOrderContext context) : base(context){}
        public ClientExecuter(){}

        public IEnumerable<EClient> GetFiltrdClients(string filter)
        {
            IEnumerable<EClient> result;
            if (string.IsNullOrEmpty(filter))
            {
                result = GetAll();
            }
            else
            {
                result = GetAll().ToList().Where(r =>
                    (!string.IsNullOrEmpty(r.Name) && r.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1) ||
                    (!string.IsNullOrEmpty(r.Phone) && r.Phone.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1) ||
                    (!string.IsNullOrEmpty(r.Mail) && r.Mail.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1));
            }
            return result.OrderByDescending(r => r.Date).ThenBy(r => r.Name);
        }
    }
}