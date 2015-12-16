using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tBackupLog")]
    public class BackupLog
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fDate")]
        public int date { get; set; }

        [NotMapped]
        public DateTime Date
        {
            get
            {
                return DateLib.GetDateFromInt(date);
            }
            set
            {
                date = DateLib.GetDateInt(value);
            }
        }

        [Column("fResult")]
        public int result { get; set; }

        [NotMapped]
        public bool Result
        {
            get
            {
                return result == 1;
            }
            set
            {
                result = value ? 1 : 0;
            }
        }
    }
}
