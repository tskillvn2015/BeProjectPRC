﻿using System;
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
        public int ID;
        public String Username;
        public String ProductId;
        public DateTime Date;
        public int RatingPoint;
        [ForeignKey("ProductId")]
        public Product Product;
        [ForeignKey("Username")]
        public User User;
    }
}
