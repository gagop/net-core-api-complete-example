using CoreEx.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CoreEx.Persistence
{
    public class ProductsDbContextFactory : DesignTimeDbContextFactoryBase<ProductsDbContext>
    {
        protected override ProductsDbContext CreateNewInstance(DbContextOptions<ProductsDbContext> options)
        {
            return new ProductsDbContext(options);
        }
    }
}
