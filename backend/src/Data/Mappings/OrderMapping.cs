using MStarSupply.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MStarSupply.Mappings;

public class OrderMapping : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(p => p.OrderId);
        builder.Property(p => p.Date).HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
        builder.Property(p => p.Location).HasColumnType("VARCHAR(64)").IsRequired();
        builder.Property(p => p.OrderType).HasConversion<string>().IsRequired();

        builder.HasIndex(p => p.OrderId).HasDatabaseName("order_id");
    }
}