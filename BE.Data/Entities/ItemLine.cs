using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("History")]
    public class ItemLine
    {
        [ForeignKey("orderId")]
        
        public Order Order;
        [Key]
        public int OrderId;
        [ForeignKey("productId")]
        public Product Product;
        [Key]
        public String ProductId;
        public int Quantity;
    }
}
