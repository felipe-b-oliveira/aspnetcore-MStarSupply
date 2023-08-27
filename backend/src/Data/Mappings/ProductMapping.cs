using MStarSupply.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MStarSupply.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(p => p.ProductId);
        builder.Property(p => p.Name).HasColumnType("VARCHAR(150)").IsRequired();
        builder.Property(p => p.Manufacturer).HasColumnType("VARCHAR(128)").IsRequired();
        builder.Property(p => p.Type).HasColumnType("VARCHAR(64)").IsRequired();
        builder.Property(p => p.Amount).HasColumnType("INT").IsRequired();
        builder.Property(p => p.Description).HasColumnType("VARCHAR(254)");

        builder.HasIndex(p => p.ProductId).HasDatabaseName("product_id");
    }
}