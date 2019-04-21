using CoreEx.Persistence;
using System;

namespace CoreEx.Application.Tests.Infrastructure
{
    public class CommandTestBase : IDisposable
    {
        protected readonly ProductsDbContext _context;

        public CommandTestBase()
        {
            _context = ProductsDbContextFactory.Create();
        }

        public void Dispose()
        {
            ProductsDbContextFactory.Destroy(_context);
        }
    }
}
