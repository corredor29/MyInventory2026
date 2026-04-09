using System;
using MyInventory2026.src.modules.Products.Domain.Aggregate;
using MyInventory2026.src.modules.Products.Domain.ValueObject;

namespace MyInventory2026.src.modules.Products.Domain.Repositories;

public interface IProductRepository
{
    Task AddAsync(Products products, CancellationToken cancellationToken= default);
    
}
