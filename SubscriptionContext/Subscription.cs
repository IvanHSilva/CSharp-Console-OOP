using Oop.SharedContext;

namespace Oop.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; } = null!;
        public DateTime? EndDate { get; set; } = null!;
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
