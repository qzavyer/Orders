using System;

namespace Orders.Interfaces
{
    public interface IError
    {
        DateTime Date { get; set; }
        string Function { get; set; }
        int Id { get; set; }
        string Message { get; set; }
    }
}