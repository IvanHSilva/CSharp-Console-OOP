using Oop.SharedContext;

namespace Oop.SubscriptionContext
{
    public class Student : Base
    {
        public User User { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
