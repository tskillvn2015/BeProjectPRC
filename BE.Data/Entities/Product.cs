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
        public String ProductID;
        public String ProductName;
        public int Year;
        public String ImageURL;
        public String ImageName;
        public int Quantity;
        public double Price;
        public String Manufactor;
        public String Description;
        public bool Status;
        public List<ItemLine> ListItemLine;
        public List<PriceByTime> ListPriceByTime;
        public List<Rate> ListRate;
    }
}