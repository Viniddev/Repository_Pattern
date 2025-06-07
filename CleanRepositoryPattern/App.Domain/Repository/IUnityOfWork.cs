namespace App.Domain.Repository;

public interface IUnitOfWork
{
    Task CommitAsync();
}
