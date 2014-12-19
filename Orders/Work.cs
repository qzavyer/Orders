using System;
using System.Data;

namespace Orders
{
    class Work
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Client { get; set; }
        public Int64 Type { get; set; }
        public string TypeStr { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ExDate { get; set; }
        public double Prepay { get; set; }
        public double Excess { get; set; }
        public Int64 ConsType { get; set; }
        public double Cons { get; set; }
        public double Hours { get; set; }
        public Int64 Source { get; set; }
        public int Sert { get; set; }

        public Work(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            ClientId = Convert.ToInt32(row["ClientId"]);
            Client = row["Client"].ToString();
            Type = Convert.ToInt64(row["Type"]);
            //TypeStr = row["TypeStr"].ToString();
            Date = Convert.ToDateTime(row["Date"]);
            if(DBNull.Value!=row["ExDate"])
            ExDate = Convert.ToDateTime(row["ExDate"]);
            Prepay = Convert.ToDouble(row["Prepay"]);
            Excess = Convert.ToDouble(row["Excess"]);
            ConsType = DBNull.Value == row["ConsType"] ? 0 : Convert.ToInt32(row["ConsType"]);
            Cons = Convert.ToDouble(row["Cons"]);
            Hours = Convert.ToDouble(row["Hours"]);
            Source = Convert.ToInt64(row["Source"]);
            Sert = DBNull.Value == row["Sert"] ? 0 : Convert.ToInt32(row["Sert"]);
        }
    }


}
