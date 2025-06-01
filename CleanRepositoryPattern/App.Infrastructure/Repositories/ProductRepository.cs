using App.Domain.Entities;
using App.Domain.Repositories;
using App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repositories;

internal class ProductRepository(AppDbContext _dbContext) : IProductRepository
{
    public async Task<Products> CreateAsync(Products Products, CancellationToken cancellationToken = default)
    {
        await _dbContext.Products.AddAsync(Products, cancellationToken);

        return Products;
    }

    public async Task<Products> UpdateAsync(Products Products, CancellationToken cancellationToken = default)
    {
        _dbContext.Products.Update(Products);

        return Products;
    }

    public async Task<Products?> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var Products = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (Products != null)
        {
            _dbContext.Products.Remove(Products);
        }

        return Products;
    }

    public async Task<Products?> GetProductByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var Products = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        return Products;
    }

    public async Task<List<Products>> GetAllProducts(int skip = 0, int take = 20, CancellationToken cancellationToken = default)
    {
        var ProductsList = await _dbContext.Products
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToListAsync(cancellationToken);

        return ProductsList;
    }
}
