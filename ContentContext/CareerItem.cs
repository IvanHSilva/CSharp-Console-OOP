using Oop.NotificationContext;

namespace Oop.ContentContext
{
    public class CareerItem() : Base
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Course Course { get; set; } = null!;

        public CareerItem(int order, string title, string description, Course course) : this()
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso Inválido!"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}
