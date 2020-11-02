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
        public int OrderId;
        public String Username;
        public String PhoneNumber;
        public String Address;
        public String CreationDate;
        public String Description;
        public int Status;
        public List<ItemLine> ListItem;
        [ForeignKey("Username")]
        public User User;
    }
}
