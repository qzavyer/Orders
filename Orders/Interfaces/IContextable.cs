namespace Orders.Interfaces
{
    public interface IContextable
    {
        IOrderContext Context { get; }
    }
}