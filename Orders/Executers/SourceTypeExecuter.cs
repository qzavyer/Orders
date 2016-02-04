using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Orders.Classes;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class SourceTypeExecuter : IOrderEntry<ESourceType>, IContextable
    {
        public SourceTypeExecuter(IOrderContext context)
        {
            Context = context;
        }

        public SourceTypeExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<ESourceType> GetTypes()
        {
            return Context.SourceTypes;
        }

        public IEnumerable<ESourceType> GetFilteredTypes(string filter)
        {
            IEnumerable<ESourceType> result;
            if (string.IsNullOrEmpty(filter))
            {
                result = GetTypes();
            }
            else
            {
                result = GetTypes().ToList().Where(r =>
                    (r.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1));
            }
            return result.OrderBy(r => r.Name);
        }

        public ESourceType Add(ESourceType entry)
        {
            return Context.SourceTypes.Add(entry);
        }

        public ESourceType Get(object id)
        {
            try
            {
                var typeId = Convert.ToInt32(id);
                return Context.SourceTypes.SingleOrDefault(r => r.Id == typeId);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                return null;
            }
        }

        public void Update(ESourceType entry)
        {
            if (entry == null) return;
            var type = Get(entry.Id);
            if (type == null) return;
            type.Name = entry.Name;
        }

        public void Delete(object id)
        {
            var type = Get(id);
            Context.SourceTypes.Remove(type);
        }

        public IOrderContext Context { get; }
    }
}