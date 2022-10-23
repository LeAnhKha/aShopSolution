using aShopSolution.Data.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Configuations
{

    // khóa nhiều nhiều
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId }); // câu lệnh chỉ ra key của từng bảng

            builder.ToTable("ProductInCategories");

            builder.HasOne(t => t.Category).WithMany(pc => pc.productInCategories)
                .HasForeignKey(pc => pc.CategoryId); // câu lệnh này tạo khóa ngoại để trỏ tới 2 bảng là category và productIncategory

            builder.HasOne(t => t.Product).WithMany(pc => pc.productInCategories)
                .HasForeignKey(pc => pc.ProductId);
        }
    }
}
