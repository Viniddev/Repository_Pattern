using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryPatternPrj.Models;

namespace RepositoryPatternPrj.Data.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(x => x.IsActive)
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(x => x.Name)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(160)
            .IsRequired(true);

        builder.Property(x => x.Price)
            .HasColumnType("DECIMAL")
            .HasDefaultValue(0)
            .IsRequired(true);

        builder.ToTable("Products");
    }
}
