using Oop.SharedContext;

namespace Oop.ContentContext
{
    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; } = string.Empty;
        public IList<Lecture> Lectures { get; set; }

        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }
}
