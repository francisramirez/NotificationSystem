

namespace NotificationSystem.Domain.Interfaces
{
    public delegate void NotificationHandler(string recipient, string message);
    public interface INotificationEvent
    {
        event NotificationHandler OnNotificationSent;
        void SendNotification(string recipient, string message);
    }
}
