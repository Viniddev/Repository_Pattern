using Microsoft.EntityFrameworkCore;
using RepositoryPatternPrj.Models;
using System.Reflection;

namespace RepositoryPatternPrj.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
