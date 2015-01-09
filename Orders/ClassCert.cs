using System;

namespace Orders
{
    public class Cert
    {
        public int Id { get; set; }
        public int PayId { get; set; }
        public string PayName { get; set; }
        public int Clientid { get; set; }
        public string ClientName { get; set; }
        public Int32 TypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime DatePay { get; set; }
        public DateTime DateEnd { get; set; }
        public double Price { get; set; }
        public double Cons { get; set; }
        public int Hours { get; set; }
        public Int32 Source { get; set; }
        public string SourceName { get; set; }
    }
}
