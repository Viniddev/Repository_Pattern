using App.Domain.Abstractions.Interfaces;

namespace App.Domain.Repositories;
public interface IRepository<T> where T : IAggregateRoot;
