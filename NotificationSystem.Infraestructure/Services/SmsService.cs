

using NotificationSystem.Domain.Events;

namespace NotificationSystem.Infraestructure.Services
{
    public class SmsService
    {
        public SmsService(NotificationPublisher publisher)
        {
            publisher.OnNotificationSent += Publisher_OnNotificationSentSms; ; 
        }

        private void Publisher_OnNotificationSentSms(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }
}
