using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("Rate")]
    public class Rate
    {
        [Key]
        public int ID { get; set; }
        public String Username { get; set; }
        public String ProductId { get; set; }
        public DateTime Date { get; set; }
        public int RatingPoint { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("Username")]
        public User User { get; set; }
    }
}
