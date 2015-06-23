using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tCons")]
    public class ECons
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public EConsType Type { get; set; }

        [Column("fAmount")]
        public double Amount { get; set; }

        [Column("fComment")]
        public string Comment { get; set; }

        [Column("fCertCons")]
        public int CertCons { get; set; }

        [Column("fWorkId")]
        public int WorkId { get; set; }

        [NotMapped]
        [ForeignKey("WorkId")]
        public EWork Work { get; set; }

        [Column("fCertId")]
        public int CertId { get; set; }

        [NotMapped]
        [ForeignKey("CertId")]
        public ECert Cert { get; set; }

        [Column("fDate")]
        public int _date { get; set; }

        [NotMapped]
        public DateTime Date
        {
            get
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                return date.AddSeconds(_date);
            }
            set
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - date;
                _date = (int) span.TotalSeconds;
            }
        }
    }
}