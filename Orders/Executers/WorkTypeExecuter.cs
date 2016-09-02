using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Orders.Classes;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class WorkTypeExecuter : BaseExecuter<EWorkType, EWorkType>
    {
        public WorkTypeExecuter(IExecuter executer) : base(executer){ }
        public WorkTypeExecuter(IOrderContext context) : base(context){ }
        public WorkTypeExecuter() { }

        public IEnumerable<EWorkType> GetFilteredTypes(string filter)
        {
            IEnumerable<EWorkType> result;
            if (string.IsNullOrEmpty(filter))
            {
                result = GetAll();
            }
            else
            {
                result = GetAll().ToList().Where(r =>
                    (r.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) > -1));
            }
            return result.OrderBy(r => r.Name);
        }
    }
}