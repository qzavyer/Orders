using System;

namespace Orders.Interfaces
{
    public interface IBackupLog
    {
        DateTime Date { get; set; }
        int date { get; set; }
        int Id { get; set; }
        bool Result { get; set; }
        int result { get; set; }
    }
}