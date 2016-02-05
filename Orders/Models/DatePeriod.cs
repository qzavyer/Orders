using System;
using Orders.Classes;

namespace Orders.Models
{
    public class DatePeriod
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int SqlStart => Start.ToSqlDate();
        public int SqlEnd => End.ToSqlDate();
    }
}