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
        public String Username { get; set; }

        public String Address { get; set; }

        public String Birthday { get; set; }

        public String Description { get; set; }

        public String Email { get; set; }

        public String Fullname { get; set; }

        public String Password { get; set; }

        public String Phone { get; set; }

        public int RoleId { get; set; }

        public bool Status { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public List<Order> ListOrder { get; set; }
    }
}
