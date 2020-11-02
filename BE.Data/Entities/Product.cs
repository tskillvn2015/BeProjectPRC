using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE.Data.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public String productID;
        public String phoneName;
        public int year;
        public String imageURL;
        public String imageName;
        public int quantity;
        public double price;
        public String manufactor;
        public String description;
        public float ratingPoint;
        public bool status;
    }
}