﻿using BE.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<ItemLine> ItemLine { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PriceByTime> PriceByTime { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserSearchBehaviour> UserSearchBehaviour { get; set; }
    }
}
