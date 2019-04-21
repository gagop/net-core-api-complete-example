using CoreEx.Domain.Entities;
using System.Collections.Generic;

namespace CoreEx.Persistence
{
    public class ProductsInitializer
    {
        private readonly Dictionary<int, Product> Products = new Dictionary<int, Product>();

        public static void Initialize(ProductsDbContext context)
        {
            var initializer = new ProductsInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            //if (context.Customers.Any())
            //{
            //    return; // Db has been seeded
            //}

            //SeedCustomers(context);
        }
    }
}