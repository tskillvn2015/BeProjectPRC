using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE.Data.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public String ProductID { get; set; }
        public String ProductName { get; set; }
        public int Year { get; set; }
        public String ImageURL { get; set; }
        public String ImageName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public String Manufactor { get; set; }
        public String Description { get; set; }
        public bool Status { get; set; }
        public List<ItemLine> ListItemLine { get; set; }
        public List<PriceByTime> ListPriceByTime { get; set; }
        public List<Rate> ListRate { get; set; }
    }
}