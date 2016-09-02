using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class ConsTypeExecuter : BaseExecuter<EConsType, EConsType>
    {
        public ConsTypeExecuter(IExecuter executer) : base(executer) { }
        public ConsTypeExecuter(IOrderContext context) : base(context) { }
        public ConsTypeExecuter() { }
    }
}