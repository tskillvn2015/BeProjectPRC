using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BE.Data.Entities
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id;
        public String Name;
        public String Description;
        public String Permission;
        public String Status;
    }
}
