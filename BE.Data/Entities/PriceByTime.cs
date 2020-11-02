using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("PriceByTime")]
    public class PriceByTime
    {
        
        [ForeignKey("ProductId")]
        public Product Product;
        [Key]
        public String ProductID;
        [Key]
        [Required]
        public DateTime Date;
        [Required]
        public float Price;
        public String Description;
        public bool Status;

    }
}
