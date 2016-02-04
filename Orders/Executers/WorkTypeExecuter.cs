using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Orders.Classes;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class WorkTypeExecuter : IOrderEntry<EWorkType>, IContextable
    {
        public WorkTypeExecuter(IOrderContext context)
        {
            Context = context;
        }

        public WorkTypeExecuter() : this(new OrderContext())
        {
        }

        public IEnumerable<EWorkType> GetTypes()
        {
            return Context.WorkTypes;
        }

        public IEnumerable<EWorkType> GetFilteredTypes(string filter)
        {
            IEnumerable<EWorkType> result;
            if (string.IsNullOrEmpty(filter))
            {
                result =GetTypes();
            }
            else
            {
                result = GetTypes().ToList().Where(r =>
                    (r.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1));
            }
            return result.OrderBy(r => r.Name);
        }

        public EWorkType Add(EWorkType type)
        {
            return Context.WorkTypes.Add(type);
        }

        public EWorkType Get(object id)
        {
            try
            {
                var typeId = Convert.ToInt32(id);
                return Context.WorkTypes.SingleOrDefault(r => r.Id == typeId);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                return null;
            }
        }

        public void Update(EWorkType entry)
        {
            if(entry==null) return;
            var type = Get(entry.Id);
            if(type==null) return;
            type.Name = entry.Name;
        }

        public void Delete(object id)
        {
            var type = Get(id);
            Context.WorkTypes.Remove(type);
        }
        
        public IOrderContext Context { get; }
    }
}