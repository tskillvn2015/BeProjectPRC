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
        public String username;

        public String address;

        public String birthday;

        public String description;

        public String email;

        public String fullname;

        public String password;

        public String phone;

        public int roleId;

        public bool status;
    }
}
