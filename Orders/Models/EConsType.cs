using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tConsType")]
    public class EConsType:OrderEntity<EConsType>
    {
        [Key]
        [Column("fId")]
        public override int Id { get; set; }

        public override void Edit(OrderEntity<EConsType> entity)
        {
            
        }

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