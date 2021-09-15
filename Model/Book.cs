using AulaUdemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulaUdemy.Model
{
    [Table ("books")]
    public class Book : BaseEntity
    {
        [Column("author")]
        public string author { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
