using BE.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Configurations
{
    public class ItemLineConfiguration : IEntityTypeConfiguration<ItemLine>
    {
        public void Configure(EntityTypeBuilder<ItemLine> builder)
        {
            builder.ToTable("ItemLine");

            builder.HasKey(x => new { x.OrderId,x.ProductId });

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ListItemLine)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.ListItem)
                .HasForeignKey(x => x.OrderId);

            builder.Property(x => x.Quantity).IsRequired().HasDefaultValue(0);
        }
    }
}
