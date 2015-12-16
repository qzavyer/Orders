﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders
{
    [Table("tClient")]
    public class EClient
    {
        [Key]
        [Column("fId")]
        public int Id { get; set; }

        [Column("fName")]
        public string Name { get; set; }

        [Column("fPhone")]
        public string Phone { get; set; }

        [Column("fEmail")]
        public string Mail { get; set; }

        [Column("fNote")]
        public string Note { get; set; }

        [Column("fDate")]
        public int idate { get; set; }

        [NotMapped]
        public DateTime Date
        {
            get
            {
                var tdate = new DateTime(1970, 1, 1, 0, 0, 0);
                return tdate.AddSeconds(idate);
            }
            set
            {
                var tdate = new DateTime(1970, 1, 1, 0, 0, 0);
                var span = value - tdate;
                idate = (int) span.TotalSeconds;
            }
        }

        public EClient()
        {
            var date = DateTime.Now;
            Date = new DateTime(date.Year, date.Month, date.Day);
        }
    }
}