using System;

namespace Orders.Interfaces
{
    public interface IEClient
    {
        DateTime Date { get; set; }
        int Id { get; set; }
        int idate { get; set; }
        string Mail { get; set; }
        string Name { get; set; }
        string Note { get; set; }
        string Phone { get; set; }
    }
}