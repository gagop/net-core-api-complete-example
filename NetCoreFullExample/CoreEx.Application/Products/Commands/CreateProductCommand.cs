using CoreEx.Application.Interfaces;
using CoreEx.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEx.Application.Products.Commands
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public class Handler : IRequestHandler<CreateProductCommand, Unit>
        {
            private readonly IProductsDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IProductsDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var entity = new Product
                {
                    Name = request.Name,
                    Category = request.Category,
                    CreatedAt = DateTime.Now
                };

                await _context.Products.AddAsync(entity);
                await _context.SaveChangesAsync(cancellationToken);
                await _mediator.Publish(new ProductCreated { ProductId = entity.IdProduct }, cancellationToken);

                return Unit.Value;
            }
        }

    }
}
