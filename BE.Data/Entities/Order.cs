using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public String orderId;
        public String username;
        public String phoneNumber;
        public String address;
        public String creationDate;
        public List<ItemLine> listItem;
        public String description;
        public int status;
    }
}
