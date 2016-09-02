using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tSert")]
    public class ECert:OrderEntity<ECert>
    {
        [Key]
        [Column("fId")]
        public override int Id { get; set; }

        public override void Edit(OrderEntity<ECert> entity)
        {
            var cert = (ECert) entity;
            PayId = cert.PayId;
        }

        [Column("fPayId")]
        public int PayId { get; set; }

        [ForeignKey("PayId")]
        public EClient Payer { get; set; }

        [Column("fClientId")]
        public int? ClientId { get; set; }

        [ForeignKey("ClientId")]
        public EClient Client { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public EWorkType Type { get; set; }

        [Column("fDatePay")]
        public int datePay { get; set; }

        [Column("fDateEnd")]
        public int dateEnd { get; set; }

        [Column("fPrice")]
        public double Price { get; set; }

        [Column("fHours")]
        public double Hours { get; set; }

        [Column("fCash")]
        public int Cash { get; set; }

        [Column("fSource")]
        public int SourceId { get; set; }

        [Column("fConsed")]
        public double consed { get; set; }

        [NotMapped]
        public double Consed
        {
            get { return consed; }
            set
            {
                consed = value;
            }
        }

        [ForeignKey("SourceId")]
        public ESourceType Source { get; set; }

        [NotMapped]
        public DateTime DatePay
        {
            get
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(datePay);
            }
            set
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - date;
                datePay = (int)span.TotalSeconds;
                DateEnd = value.AddMonths(3);
            }
        }

        [NotMapped]
        public DateTime DateEnd
        {
            get
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(dateEnd);
            }
            set
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - date;
                dateEnd = (int)span.TotalSeconds;
            }
        }

        [NotMapped]
        public bool IsCash
        {
            get { return Cash == 1; }
            set
            {
                Cash = value ? 1 : 0;
                if (value) Consed = Price;
            }
        }

        [NotMapped]
        public int RowId { get; set; }
    }

    public abstract class OrderEntity<T>
    {
        public virtual int Id { get; set; }
        public abstract void Edit(OrderEntity<T> entity);
    }
}

