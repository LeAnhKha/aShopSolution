using aShopSolution.Data.Entitis;
using aShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Configuations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active); // nếu k nhập gì thì giá trị mặt định là active / khóa nhiều nhiều
        }
    }
}
