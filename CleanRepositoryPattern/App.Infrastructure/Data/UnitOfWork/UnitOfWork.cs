using App.Domain.Abstractions.Interfaces;

namespace App.Infrastructure.Data.UnitOfWork;
public class UnitOfWork(AppDbContext _dbContext) : IUnitOfWork
{
    public async Task CommitAsync()
    {
        await _dbContext.SaveChangesAsync();  
    }
}
