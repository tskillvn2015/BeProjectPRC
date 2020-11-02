using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("UserSearchBehaviour")]
    public class UserSearchBehaviour
    {
        [Key]
        public int Id { get; set; }
        public String Username { get; set; }
        public String SearchValue { get; set; }
        public String Date { get; set; }
    }
}
