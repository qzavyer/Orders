using System;

namespace Orders.Interfaces
{
    public interface IECert
    {
        int Cash { get; set; }
        IEClient Client { get; set; }
        int? ClientId { get; set; }
        double Consed { get; set; }
        double consed { get; set; }
        DateTime DateEnd { get; set; }
        int dateEnd { get; set; }
        DateTime DatePay { get; set; }
        int datePay { get; set; }
        double Hours { get; set; }
        int Id { get; set; }
        bool IsCash { get; set; }
        IEClient Payer { get; set; }
        int PayId { get; set; }
        double Price { get; set; }
        int RowId { get; set; }
        IESourceType Source { get; set; }
        int SourceId { get; set; }
        IEWorkType Type { get; set; }
        int TypeId { get; set; }
    }
}