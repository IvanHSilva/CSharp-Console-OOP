namespace Oop.ContentContext
{
    public class Career(string title, string url) : Content(title, url)
    {
        public IList<CareerItem> Courses { get; set; } = new List<CareerItem>();
        public int TotalCourses => Courses.Count;
    }
}
