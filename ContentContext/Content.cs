using Oop.SharedContext;

namespace Oop.ContentContext
{
    public abstract class Content(string title, string url) : Base
    {
        public string Title { get; set; } = title;
        public string Url { get; set; } = url;
    }
}
