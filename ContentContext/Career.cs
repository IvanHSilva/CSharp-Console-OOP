namespace Oop.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Courses { get; set; }
        public int TotalCourses => Courses.Count;

        public Career()
        {
            Courses = new List<CareerItem>();
        }
    }
}
