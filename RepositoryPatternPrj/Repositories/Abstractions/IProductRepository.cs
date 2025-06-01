using RepositoryPatternPrj.Models;

namespace RepositoryPatternPrj.Repositories.Abstractions;

public interface IProductRepository
{
    Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);
    Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default);
    Task<Product?> DeleteAsync(int id, CancellationToken cancellationToken = default);
    Task<Product?> GetProductByIdAsync(long id, CancellationToken cancellationToken = default);
    Task<List<Product>> GetAllProducts(int skip = 0, int take = 20, CancellationToken cancellationToken = default);
}
