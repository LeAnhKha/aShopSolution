using aShopSolution.Data.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Configuations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.HasKey(x => new { x.OrderId, x.ProductId });

            // có 1 khóa ngoài trỏ tới bảng order với 1 listOdderDetail
            builder.HasOne(x => x.Orders).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId); // cấu hình quan hệ 1 nhiều
            // có 1 khóa ngoài trỏ tới bảng product với 1 listOdderDetail                                                                                          // có 1 khóa ngoài trỏ tới bảng order với 1 listOdderDetail
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
