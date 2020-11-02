using BE.Data.Entities;
using EShop.Data.Configurations;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemLineConfiguration());
            modelBuilder.ApplyConfiguration(new PriceByTimeConfiguration());

            //base.OnModelCreating(modelBuilder);
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
