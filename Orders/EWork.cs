using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tWork")]
    public class EWork
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fClientId")]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public EClient Client { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public EWorkType Type { get; set; }

        [Column("fDate")]
        public int _datePay { get; set; }

        [Column("fExcessDate")]
        public int? _dateExcess { get; set; }

        [Column("fPrepay")]
        public double Prepay { get; set; }

        [Column("fExcess")]
        public double Excess { get; set; }

        [Column("fHours")]
        public double Hours { get; set; }

        [Column("fSourceId")]
        public int SourceId { get; set; }

        [ForeignKey("SourceId")]
        public ESourceType Source { get; set; }

        [Column("fSertId")]
        public int? CertId { get; set; }

        [ForeignKey("CertId")]
        public ECert Cert { get; set; }

        [NotMapped]
        public double Cons { get; set; }
        
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
                _datePay = DateLib.GetDateInt(value);
            }
        }

        [NotMapped]
        public DateTime? DateExcess
        {
            get
            {
                if (_dateExcess == null) return null;
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(_dateExcess.Value);
            }
            set
            {
                if (value == null)
                {
                    _dateExcess = null;
                    return;
                }
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value.Value - date;
                _dateExcess = (int) span.TotalSeconds;
            }
        }
    }
}