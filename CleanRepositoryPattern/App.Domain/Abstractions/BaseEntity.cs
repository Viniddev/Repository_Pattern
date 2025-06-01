namespace App.Domain.Abstractions;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; } = true;
}
