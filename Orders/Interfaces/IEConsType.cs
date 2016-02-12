namespace Orders.Interfaces
{
    public interface IEConsType
    {
        int certCons { get; set; }
        int Id { get; set; }
        bool IsCertCons { get; set; }
        string Name { get; set; }
    }
}