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
        public int OrderId { get; set; }
        public String Username { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String CreationDate { get; set; }
        public String Description { get; set; }
        public int Status { get; set; }
        public List<ItemLine> ListItem { get; set; }
        [ForeignKey("Username")]
        public User User { get; set; }
    }
}
