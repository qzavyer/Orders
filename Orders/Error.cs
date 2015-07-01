using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tError")]
    public class Error
    {
        [Key]
        [Column("fDate")]
        public int Id { get; set; }

        [NotMapped]
        public DateTime Date
        {
            get { return DateLib.GetDateFromInt(Id); }
            set { Id = DateLib.GetDateInt(value); }
        }

        [Column("fError")]
        public string Message { get; set; }

        [Column("fFunc")]
        public string Function { get; set; }
    }
}
