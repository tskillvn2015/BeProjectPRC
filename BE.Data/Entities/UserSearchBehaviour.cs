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
        public String id;
        public String username;
        public String searchValue;
        public int weight;
        public String date;
    }
}
