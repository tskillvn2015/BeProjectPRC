using BE.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Configurations
{
    public class PriceByTimeConfiguration : IEntityTypeConfiguration<PriceByTime>
    {
        public void Configure(EntityTypeBuilder<PriceByTime> builder)
        {
            builder.ToTable("PriceByTime");

            builder.HasKey(x => new { x.ProductID, x.Date });

            builder.HasOne(x => x.Product).WithMany(x => x.ListPriceByTime).HasForeignKey(x => x.ProductID);

            builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(false);
        }
    }
}
