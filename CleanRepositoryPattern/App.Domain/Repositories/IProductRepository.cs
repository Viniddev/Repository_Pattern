using App.Domain.Entities;

namespace App.Domain.Repositories;

public interface IProductRepository : IRepository<Products>
{
    Task<Products> CreateAsync(Products product, CancellationToken cancellationToken = default);
    Task<Products> UpdateAsync(Products product, CancellationToken cancellationToken = default);
    Task<Products?> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Products?> GetProductByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Products>> GetAllProducts(int skip = 0, int take = 20, CancellationToken cancellationToken = default);
}
