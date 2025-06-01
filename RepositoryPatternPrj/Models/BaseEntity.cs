namespace RepositoryPatternPrj.Models;

public class BaseEntity
{
    public long Id { get; set; }
    public bool IsActive { get; set; } = true;
}
