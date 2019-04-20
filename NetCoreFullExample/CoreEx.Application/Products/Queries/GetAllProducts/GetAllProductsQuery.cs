using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreEx.Application.Interfaces;
using CoreEx.Application.Products.Queries.GetAllProducts.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEx.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ProductsListDto>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ProductsListDto>
        {
            private readonly IProductsDbContext _context;
            private readonly IMapper _mapper;

            public GetAllProductsQueryHandler(IProductsDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ProductsListDto> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                return new ProductsListDto
                {
                    Products = await _context.Products.ProjectTo<ProductDto>(_mapper.ConfigurationProvider).ToListAsync()
                };
            }
        }
    }
}
