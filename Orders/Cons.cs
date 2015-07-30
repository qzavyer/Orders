using System;
using System.Data;

namespace Orders
{
    public class Cons
    {
        public Int64 Type { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public Cons(){}
        public Cons(DataRow row)
        {
            Type = Convert.ToInt32(row["Type"]);
            Comment = row["Comment"].ToString();
            Type = Convert.ToInt64(row["Type"]);
            //TypeStr = row["TypeStr"].ToString();
            Date = Convert.ToDateTime(row["Date"]);
            if (DBNull.Value != row["Date"])
                Date = Convert.ToDateTime(row["Date"]);
            Amount = Convert.ToDouble(row["Amount"]);
        }
    }
}
