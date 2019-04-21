using AutoMapper;
using CoreEx.Persistence;
using System;
using Xunit;

namespace CoreEx.Application.Tests.Infrastructure
{
    public class QueryTestFixture : IDisposable
    {
        public ProductsDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = ProductsDbContextFactory.Create();
            Mapper = AutoMapperFactory.Create();
        }

        public void Dispose()
        {
            ProductsDbContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
