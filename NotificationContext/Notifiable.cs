namespace Oop.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; } = null!;

        public Notifiable()
        {
            Notifications = [];
        }
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalid => Notifications.Any();
    }
}
