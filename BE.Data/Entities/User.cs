using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public String Username;

        public String Address;

        public String Birthday;

        public String Description;

        public String Email;

        public String Fullname;

        public String Password;

        public String Phone;

        public int RoleId;

        public bool Status;

        [ForeignKey("RoleId")]
        public Role Role;

        public List<Order> ListOrder;
    }
}
