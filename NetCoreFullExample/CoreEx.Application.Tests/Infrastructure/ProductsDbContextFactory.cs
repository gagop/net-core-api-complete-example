using CoreEx.Domain.Entities;
using CoreEx.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreEx.Application.Tests.Infrastructure
{
    public class ProductsDbContextFactory
    {
        public static ProductsDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ProductsDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ProductsDbContext(options);

            context.Database.EnsureCreated();

            context.Products.AddRange(new[] {
                new Product { IdProduct = 1, Name="Oranges", Category="Fruits", CreatedAt=DateTime.Now}
            });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(ProductsDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
