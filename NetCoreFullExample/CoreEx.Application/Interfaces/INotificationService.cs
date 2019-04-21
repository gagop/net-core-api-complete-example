using CoreEx.Application.Notifications.Models;
using System.Threading.Tasks;

namespace CoreEx.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
