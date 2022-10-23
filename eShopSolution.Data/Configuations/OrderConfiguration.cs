﻿using aShopSolution.Data.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace aShopSolution.Data.Configuations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ShipAddress).IsRequired().IsUnicode(false).HasMaxLength(50); // không muốn cho nó unicode
        }
    }
}
