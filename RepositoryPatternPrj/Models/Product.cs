namespace RepositoryPatternPrj.Models;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
