using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tSert")]
    public class ECert
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fPayId")]
        public int PayId { get; set; }

        [NotMapped]
        [ForeignKey("PayId")]
        public EClient Payer { get; set; }

        [Column("fClientId")]
        public int ClientId { get; set; }

        [NotMapped]
        [ForeignKey("ClientId")]
        public EClient Client { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [NotMapped]
        [ForeignKey("TypeId")]
        public EWorkType Type { get; set; }

        [Column("fDatePay")]
        public int _datePay { get; set; }

        [Column("fDateEnd")]
        public int _dateEnd { get; set; }

        [Column("fPrice")]
        public double Price { get; set; }

        [Column("fHours")]
        public double Hours { get; set; }

        [Column("fCash")]
        public int Cash { get; set; }

        [Column("fSource")]
        public int SourceId { get; set; }

        [NotMapped]
        [ForeignKey("SourceId")]
        public ESourceType Source { get; set; }

        [NotMapped]
        public DateTime DatePay
        {
            get
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(_datePay);
            }
            set
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - date;
                _datePay = (int) span.TotalSeconds;
            }
        }

        [NotMapped]
        public DateTime DateEnd
        {
            get
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(_dateEnd);
            }
            set
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - date;
                _dateEnd = (int) span.TotalSeconds;
            }
        }
    }
}