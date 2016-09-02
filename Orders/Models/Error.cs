using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Orders.Classes;

namespace Orders.Models
{
    [Table("tError")]
    public class Error:OrderEntity<Error>
    {
        [Key]
        [DisplayName("ID")]
        [Column("fDate")]
        public override int Id { get; set; }

        public override void Edit(OrderEntity<Error> entity)
        {
            
        }

        [NotMapped]
        [DisplayName("Дата")]
        public DateTime Date
        {
            get { return Id.ToDateTime(); }
            set { Id = value.ToSqlDate(); }
        }

        [Column("fError")]
        [DisplayName("Описание")]
        public string Message { get; set; }

        [Column("fFunc")]
        [DisplayName("Имя функции")]
        public string Function { get; set; }
    }
}
