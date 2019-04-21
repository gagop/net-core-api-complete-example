using AutoMapper;
using CoreEx.Application.Products.Queries.GetAllProducts;
using CoreEx.Application.Products.Queries.GetAllProducts.Models;
using CoreEx.Application.Tests.Infrastructure;
using CoreEx.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static CoreEx.Application.Products.Queries.GetAllProducts.GetAllProductsQuery;

namespace CoreEx.Application.Tests.Products.Queries
{
    [Collection("QueryCollection")]
    public class GetAllProductsQueryHandlerTests
    {
        private readonly ProductsDbContext _context;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetAllProductsTest()
        {
            var sut = new GetAllProductsQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetAllProductsQuery(), CancellationToken.None);

            result.ShouldBeOfType<ProductsListDto>();
            result.Products.Count.ShouldBe(1);
        }
    }
}
