using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Orders.Classes;

namespace Orders.Models
{
    [Table("tWork")]
    public class EWork
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fClientId")]
        public int ClientId { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public EWorkType Type { get; set; }

        [Column("fDate")]
        public int datePay { get; set; }

        [Column("fExcessDate")]
        public int? dateExcess { get; set; }

        [Column("fPrepay")]
        public double Prepay { get; set; }

        [Column("fExcess")]
        public double Excess { get; set; }

        [Column("fDuty")]
        public double Duty { get; set; }

        [Column("fHours")]
        public double Hours { get; set; }

        [Column("fSourceId")]
        public int SourceId { get; set; }

        [Column("fSertId")]
        public int? CertId { get; set; }

        [ForeignKey("SourceId")]
        public ESourceType Source { get; set; }

        [ForeignKey("ClientId")]
        public EClient Client { get; set; }

        [ForeignKey("CertId")]
        public ECert Cert { get; set; }

        public ICollection<ECons> Conses { get; set; }

        [NotMapped]
        public double Cons => Conses?.Sum(r => r.Amount) ?? 0;
        
        [NotMapped]
        public DateTime DatePay
        {
            get
            {
                return datePay.ToDateTime();
            }
            set
            {
                datePay = value.ToSqlDate();
            }
        }

        [NotMapped]
        public DateTime? DateExcess
        {
            get
            {
                if (dateExcess == null) return null;
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(dateExcess.Value);
            }
            set
            {
                if (value == null)
                {
                    dateExcess = null;
                    return;
                }
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value.Value - date;
                dateExcess = (int) span.TotalSeconds;
            }
        }

        //public List<ECons> Conses { get; set; }
    }
}