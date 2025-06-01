using App.Domain.Abstractions;
using App.Domain.Abstractions.Interfaces;

namespace App.Domain.Entities;

public class Products: BaseEntity, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
