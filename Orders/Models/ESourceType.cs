using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tSource")]
    public class ESourceType:OrderEntity<ESourceType>
    {
        [Key]
        [Column("fId")]
        public override int Id { get; set; }

        public override void Edit(OrderEntity<ESourceType> entity)
        {
            
        }

        [Column("fName")]
        public string Name { get; set; }
    }
}