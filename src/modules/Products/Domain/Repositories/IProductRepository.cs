using System;
using MyInventory2026.src.modules.Products.Domain.Aggregate;
using MyInventory2026.src.modules.Products.Domain.ValueObject;

namespace MyInventory2026.src.modules.Products.Domain.Repositories;

public interface IProductRepository
{
    Task AddAsync( Product products, CancellationToken cancellationToken= default);
    Task <Product?> FindByIdAsync(ProductsId id, CancellationToken cancellationToken = default);
    Task <IReadOnlyCollection<Product>> FindAllAsync (CancellationToken cancellationToken= default);
    Task UpdateAsync(Product product, CancellationToken cancellationToken= default);
    Task<bool> DeleteByIsAsync (ProductsId id, CancellationToken cancellationToken = default);  
}
