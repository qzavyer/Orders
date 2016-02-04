using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Models
{
    [Table("tSource")]
    public class ESourceType
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fName")]
        public string Name { get; set; }
    }
}