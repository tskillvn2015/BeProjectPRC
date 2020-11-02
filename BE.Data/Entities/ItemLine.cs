using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("History")]
    public class ItemLine
    {
        public String orderId;
        public String productId;
        public int quantity;
    }
}
