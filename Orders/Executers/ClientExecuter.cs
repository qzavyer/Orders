using System;
using System.Collections.Generic;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ClientExecuter : IContextable
    {
        public ClientExecuter(IOrderContext context)
        {
            Context = context;
        }

        public ClientExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<EClient> GetClients()
        {
            return Context.Clients;
        }

        public IEnumerable<EClient> GetFiltrdClients(string filter)
        {
            IEnumerable<EClient> result;
            if (string.IsNullOrEmpty(filter))
            {
                result = GetClients();
            }
            else
            {
                result = GetClients().ToList().Where(r =>
                    (!string.IsNullOrEmpty(r.Name) && r.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1) ||
                    (!string.IsNullOrEmpty(r.Phone) && r.Phone.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1) ||
                    (!string.IsNullOrEmpty(r.Mail) && r.Mail.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1));
            }
            return result.OrderByDescending(r => r.Date).ThenBy(r => r.Name);
        }

        public EClient Get(object Id)
        {
            try
            {
                var clientId = Convert.ToInt32(Id);
                return Context.Clients.SingleOrDefault(r => r.Id == clientId);
            }
            catch
            {
                return null;
            }
        }

        public IOrderContext Context { get; }
    }    
}