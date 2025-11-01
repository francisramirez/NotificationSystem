

using NotificationSystem.Domain.Events;

namespace NotificationSystem.Infraestructure.Services
{
    public class PushNotificationService
    {
        public PushNotificationService(NotificationPublisher publisher)
        {
            publisher.OnNotificationSent += Publisher_OnNotificationSentPush; 
        }

        private void Publisher_OnNotificationSentPush(string recipient, string message)
        {
            Console.WriteLine($"Push notification sent to {recipient}: {message}");
        }
    }
}
