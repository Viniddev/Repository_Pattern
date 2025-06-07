using App.Domain.Entities;
using App.Domain.Repository;
using App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository;

public class UserInformationsRepository(AppDbContext _dbContext) : IUserInformationsRepository
{
    public async Task<UserInformations> CreateAsync(UserInformations user, CancellationToken cancellationToken = default)
    {
        await _dbContext.UserInformations.AddAsync(user, cancellationToken);

        return user;
    }

    public UserInformations? UpdateAsync(UserInformations user, CancellationToken cancellationToken = default)
    {
        _dbContext.UserInformations.Update(user);

        return user;
    }

    public async Task<UserInformations?> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.UserInformations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (user != null)
        {
            _dbContext.UserInformations.Remove(user);
        }

        return user ?? default;
    }

    public async Task<UserInformations?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.UserInformations.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        return user ?? default;
    }

    public async Task<List<UserInformations>> GetAllUsers(int skip = 0, int take = 20, CancellationToken cancellationToken = default)
    {
        var usersList = await _dbContext.UserInformations
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToListAsync(cancellationToken);

        return usersList ?? [];
    }
}