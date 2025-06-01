using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace App.Infrastructure.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Products> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);
    }
}
