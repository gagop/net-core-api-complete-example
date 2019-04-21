using CoreEx.Application.Interfaces;
using CoreEx.Application.Notifications.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CoreEx.Application.Products.Commands
{
    public class ProductCreated : INotification
    {
        public int ProductId { get; set; }

        public class ProductCreatedHandler : INotificationHandler<ProductCreated>
        {
            private readonly INotificationService _notification;

            public ProductCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(ProductCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}