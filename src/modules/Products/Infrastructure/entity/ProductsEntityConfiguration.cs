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
    }

}
