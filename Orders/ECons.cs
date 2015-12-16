using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tCons")]
    public class ECons
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fTypeId")]
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public EConsType Type { get; set; }

        [Column("fAmount")]
        public double Amount { get; set; }

        [Column("fComment")]
        public string Comment { get; set; }
        
        [Column("fWorkId")]
        public int? WorkId { get; set; }

        [ForeignKey("WorkId")]
        public EWork Work { get; set; }
      
        [Column("fDate")]
        public int date { get; set; }

        [NotMapped]
        public DateTime Date
        {
            get
            {
                var tdate = new DateTime(1970, 1, 1, 0, 0, 0);
                return tdate.AddSeconds(date);
            }
            set
            {
                var tdate = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value -tdate;
                date = (int) span.TotalSeconds;
            }
        }

        [Column("fIsCert")]
        public int iscert { get; set; }

        [NotMapped]
        public bool IsCert
        {
            get
            {
                return iscert == 1;
            }
            set
            {
                iscert = value ? 1 : 0;
            }
        }


        [NotMapped]
        public int RowId { get; set; }
    }
}