using CoreEx.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CoreEx.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(e => e.IdProduct);
            builder.Property(e => e.IdProduct).ValueGeneratedOnAdd();
            builder.Property(e => e.Category).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
