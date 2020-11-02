using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    public class ItemLine
    {
        public int OrderId { get; set; }

        public String ProductId { get; set; }

        public int Quantity { get; set; }
        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
