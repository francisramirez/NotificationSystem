

namespace NotificationSystem.Application.Interfaces
{
    public interface INotificationService
    {
        Task PublishAsync(string recipient, string message);
    }
}
