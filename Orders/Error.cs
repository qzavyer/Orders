using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tError")]
    public class Error
    {
        [Key]
        [DisplayName("ID")]
        [Column("fDate")]
        public int Id { get; set; }

        [NotMapped]
        [DisplayName("Дата")]
        public DateTime Date
        {
            get { return DateLib.GetDateFromInt(Id); }
            set { Id = DateLib.GetDateInt(value); }
        }

        [Column("fError")]
        [DisplayName("Описание")]
        public string Message { get; set; }

        [Column("fFunc")]
        [DisplayName("Имя функции")]
        public string Function { get; set; }
    }
}
