namespace Oop.ContentContext
{
    public abstract class Content
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public Content()
        {
            Id = Guid.NewGuid(); //SPOF - Single Point Of Fail
        }
    }
}