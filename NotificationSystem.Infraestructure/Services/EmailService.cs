

using NotificationSystem.Domain.Events;

namespace NotificationSystem.Infraestructure.Services
{
    public class EmailService
    {
        public EmailService(NotificationPublisher publisher)
        {
            // Subscribe to the NotificationSent event
            publisher.OnNotificationSent += Publisher_OnNotificationSentEmail; ;
        }

        private void Publisher_OnNotificationSentEmail(string recipient, string message)
        {
           Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
}
