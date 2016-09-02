using System;
using System.Collections.Generic;
using System.Linq;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class SourceTypeExecuter : BaseExecuter<ESourceType, ESourceType>
    {
        public SourceTypeExecuter(IExecuter executer) : base(executer){ }
        public SourceTypeExecuter(IOrderContext context) : base(context){ }
        public SourceTypeExecuter() { }

        public IEnumerable<ESourceType> GetFilteredTypes(string filter)
        {
            IEnumerable<ESourceType> result;
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