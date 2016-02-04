namespace Orders.Interfaces
{
    public interface IOrderEntry<T>
    {
        T Add(T entry);
        T Get(object id);
        void Update(T entry);
        void Delete(object id);
    }
}