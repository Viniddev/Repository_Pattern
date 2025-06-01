namespace App.Domain.Abstractions.Interfaces;
public interface IUnitOfWork
{
    Task CommitAsync();
}
