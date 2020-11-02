﻿using System;
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
        public int Id;
        public String Username;
        public String SearchValue;
        public String Date;
    }
}
