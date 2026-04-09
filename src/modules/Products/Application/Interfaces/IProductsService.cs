using System;
using MyInventory2026.src.modules.Products.Domain.Aggregate;

namespace MyInventory2026.src.modules.products.Application.Interfaces;

public interface IProductsService
{
    Task<Product> CreateAsync(string id, string codeInv, string nameProduct, string stock, string stock_Min, string stock_Max, CancellationToken cancellationToken = default);
    Task<Product> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<Product>> GetAllAsync(CancellationToken cancellationToken= default);
    Task<Product> UpdateAsync(string id, string codeInv, string nameProduct, string stock, string stock_Min, string stock_Max, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(string id, CancellationToken cancellationToken = default); 

}
