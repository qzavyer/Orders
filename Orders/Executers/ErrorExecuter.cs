using System.Collections.Generic;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ErrorExecuter:IContextable
    {
        public ErrorExecuter(IOrderContext context)
        {
            Context = context;
        }

        public ErrorExecuter():this(new OrderContext()){}

        public IEnumerable<Error> GetErrors()
        {
            return Context.Errors;
        }

        public void ClearErrors()
        {
            Context.Errors.RemoveRange(Context.Errors);
            Context.Save();
        }

        public IOrderContext Context { get; }
    }
}