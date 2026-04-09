using System;
using Microsoft.EntityFrameworkCore;
using MyInventory2026.src.modules.Products.Domain.Aggregate;
using MyInventory2026.src.modules.Products.Domain.Repositories;
using MyInventory2026.src.modules.Products.Domain.ValueObject;
using MyInventory2026.src.modules.products.Infrastructure.entity;
using MyInventory2026.src.shared.context;

namespace MyInventory2026.src.modules.products.Infrastructure.repository;

public sealed class ProductsRepository : IProductRepository
{
    private readonly AppDbContext _dbContext;
    public ProductsRepository (AppDbContext dbContext)
    {
        _dbContext= dbContext;
    }
    public async Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        var entity = new ProductEntity
        {
            Id =product.Id.Value,
            codeInv = product.CodeInv.Value,
            nameProduct= product.NameProduct.Value,
            stock = product.Stock.Value,
            Stock_Min = product.Stock_Min.Value,
            Stock_Max = product.Stock_Max.Value
        };
        await _dbContext.Pro
    }
}
