using System;

namespace Orders.Interfaces
{
    public interface IECons
    {
        double Amount { get; set; }
        string Comment { get; set; }
        DateTime Date { get; set; }
        int date { get; set; }
        int Id { get; set; }
        bool IsCert { get; set; }
        int iscert { get; set; }
        int RowId { get; set; }
        IEConsType Type { get; set; }
        int TypeId { get; set; }
        IEWork Work { get; set; }
        int? WorkId { get; set; }
    }
}