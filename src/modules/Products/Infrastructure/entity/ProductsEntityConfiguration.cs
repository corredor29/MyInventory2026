using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyInventory2026.src.modules.products.Infrastructure.entity;

public sealed class ProductsEntityConfiguration
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasMaxLength(64)
            .IsRequired();
        builder.Property(x => x.codeInv)
            .HasColumnName("codeInv")
            .HasMaxLength(10)
            .IsRequired();
        builder.Property(x => x.nameProduct)
            .HasColumnName("nameProduct")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.stock)
            .HasColumnName("stock")
            .HasMaxLength(64)
            .IsRequired();
        builder.Property(x => x.Stock_Min)
            .HasColumnName("stock_Min")
            .HasMaxLength(64)
            .IsRequired();
        builder.Property(x => x.Stock_Max)
            .HasColumnName("stock_Max")
            .HasMaxLength(64)
            .IsRequired();
    }

}
