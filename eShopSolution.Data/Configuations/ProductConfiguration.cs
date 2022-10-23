using aShopSolution.Data.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Configuations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Price).IsRequired();// Bắt buộc phải dữ liệu ko dc bỏ trống

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0); //nếu k nhập gì thì giá trị mặt định là active
        }
    }
}
