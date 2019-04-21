using CoreEx.Application.Interfaces;
using CoreEx.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CoreEx.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
