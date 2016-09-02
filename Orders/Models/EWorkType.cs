using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tWorkType")]
    public class EWorkType:OrderEntity<EWorkType>
    {
        [Key]
        [Column("fId")]
        public override int Id { get; set; }

        public override void Edit(OrderEntity<EWorkType> entity)
        {
            
        }

        [Column("fName")]
        public string Name { get; set; }
    }
}