using Oop.NotificationContext;
using Oop.SharedContext;

namespace Oop.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public User User { get; set; } = null!;
        public IList<Subscription> Subscriptions { get; set; } = null!;
        public bool IsPremium => Subscriptions.Any(s => !s.IsInactive);

        public Student()
        {
            Subscriptions = [];
        }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "Já tem uma assinatura ativa!"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}
