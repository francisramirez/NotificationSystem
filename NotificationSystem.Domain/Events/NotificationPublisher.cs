

using NotificationSystem.Domain.Interfaces;

namespace NotificationSystem.Domain.Events
{
    public class NotificationPublisher : INotificationEvent
    {


        public event NotificationHandler OnNotificationSent;
        public void SendNotification(string recipient, string message)
        {
        
            Console.WriteLine($"Notification sent to {recipient}: {message}");
            OnNotificationSent?.Invoke(recipient, message);
        }
    }
}
