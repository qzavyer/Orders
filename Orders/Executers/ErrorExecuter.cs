using System.Collections.Generic;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ErrorExecuter : BaseExecuter<Error, Error>
    {
        public ErrorExecuter(IExecuter executer) : base(executer){ }
        public ErrorExecuter(IOrderContext context) : base(context){ }
        public ErrorExecuter() { }

        public void ClearErrors()
        {
            
        }
    }
}