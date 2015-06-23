using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tConsType")]
    public class EConsType
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fName")]
        public string Name { get; set; }
    }
}