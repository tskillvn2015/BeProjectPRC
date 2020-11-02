using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    public class PriceByTime
    {
        public Product Product { get; set; }

        public String ProductID { get; set; }

        public DateTime Date { get; set; }

        public float Price { get; set; }
        public String Description { get; set; }
        public bool Status { get; set; }

    }
}
