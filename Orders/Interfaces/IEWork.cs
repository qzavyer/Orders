using System;
using System.Collections.Generic;

namespace Orders.Interfaces
{
    public interface IEWork
    {
        IECert Cert { get; set; }
        int? CertId { get; set; }
        IEClient Client { get; set; }
        int ClientId { get; set; }
        double Cons { get; }
        ICollection<IECons> Conses { get; set; }
        DateTime? DateExcess { get; set; }
        int? dateExcess { get; set; }
        DateTime DatePay { get; set; }
        int datePay { get; set; }
        double Duty { get; set; }
        double Excess { get; set; }
        double Hours { get; set; }
        int Id { get; set; }
        double Prepay { get; set; }
        IESourceType Source { get; set; }
        int SourceId { get; set; }
        IEWorkType Type { get; set; }
        int TypeId { get; set; }
    }
}