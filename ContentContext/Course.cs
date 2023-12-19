using Oop.ContentContext.Enums;

namespace Oop.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; } = string.Empty;
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

        public Course()
        {
            Modules = new List<Module>();
        }
    }
}