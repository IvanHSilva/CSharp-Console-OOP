using Oop.NotificationContext;

namespace Oop.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid(); //SPOF - Single Point Of Fail
        }
    }
}
