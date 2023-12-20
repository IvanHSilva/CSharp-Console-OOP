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
    }
}
