using Microsoft.EntityFrameworkCore;
using RepositoryPatternPrj.Data;
using RepositoryPatternPrj.Models;
using RepositoryPatternPrj.Repositories.Abstractions;

namespace RepositoryPatternPrj.Repositories;

public class ProductRepository(AppDbContext _dbContext): IProductRepository
{
    public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default) 
    {
        await _dbContext.Products.AddAsync(product, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return product;
    }

    public async Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default) 
    {
        _dbContext.Products.Update(product);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return product;
    }

    public async Task<Product?> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var product = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (product != null) 
        {
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        return product;
    }

    public async Task<Product?> GetProductByIdAsync(long id, CancellationToken cancellationToken = default)
    {
        var product = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        return product;
    }

    public async Task<List<Product>> GetAllProducts(int skip = 0, int take = 20, CancellationToken cancellationToken = default)
    {
        var productList = await _dbContext.Products
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToListAsync(cancellationToken);

        return productList;
    }
}
