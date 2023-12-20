using Oop.NotificationContext;

namespace Oop.ContentContext
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
