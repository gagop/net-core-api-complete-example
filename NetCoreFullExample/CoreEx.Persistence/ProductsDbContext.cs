using CoreEx.Application.Interfaces;
using CoreEx.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreEx.Persistence
{
    public class ProductsDbContext : DbContext, IProductsDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductsDbContext).Assembly);
        }

    }
}
