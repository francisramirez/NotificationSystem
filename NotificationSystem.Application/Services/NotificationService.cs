

namespace NotificationSystem.Application.Services
{

    using NotificationSystem.Application.Interfaces;
    using NotificationSystem.Domain.Events;

    public class NotificationService : INotificationService
    {
        private readonly NotificationPublisher _notificationPublisher;
        public NotificationService(NotificationPublisher notificationPublisher)
        {
            _notificationPublisher = notificationPublisher;

            //_notificationPublisher.OnNotificationSent += async (sender, args) => 
            //{
            //    await PublishAsync(args.Recipient, args.Message);
            //};

            _notificationPublisher.OnNotificationSent += _notificationPublisher_OnNotificationSent;
        }

        private void _notificationPublisher_OnNotificationSent(string recipient, string message)
        {
            Console.WriteLine($"Event received for notification to {recipient}: {message}");
        }

        public async Task PublishAsync(string recipient, string message)
        {
        

            await Task.Delay(500); // Simulate some async work
            Console.WriteLine($"Notification sent to {recipient}: {message}");
        }

    }
}
