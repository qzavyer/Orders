using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tConsType")]
    public class EConsType
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fName")]
        public string Name { get; set; }

        [Column("fCertCons")]
        public int certCons { get; set; }

        [NotMapped]
        public bool IsCertCons
        {
            get { return certCons == 1; }
            set { certCons = value ? 1 : 0; }
        }
    }
}