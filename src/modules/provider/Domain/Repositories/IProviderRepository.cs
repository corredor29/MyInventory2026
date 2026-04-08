using MyInventory2026.src.modules.provider.Domain.aggregate;
using MyInventory2026.src.modules.provider.Domain.valueObject;

namespace MyInventory2026.src.modules.provider.Domain.Repositories;

public interface IProviderRepository
{
    // Esto define el metodo de agregar 
    Task AddAsync(Provider provider, CancellationToken cancellationToken = default);
    // esto busca por ID 
    Task<Provider?> FindByIdAsync(ProviderId id, CancellationToken cancellationToken = default);
    // obtiene todos los valores osea devuelve los proveedores     
    Task<IReadOnlyCollection<Provider>> FindAllAsync(CancellationToken cancellationToken = default);
    Task UpdateAsync(Provider provider, CancellationToken cancellationToken = default);
    Task<bool> DeleteByIdAsync(ProviderId id, CancellationToken cancellationToken = default);
}