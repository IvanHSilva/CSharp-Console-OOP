using Oop.ContentContext;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();

            var articles = new List<Article>()!;
            articles.Add(new Article("Orientação a Objetos", "orientacao-objetos"));
            articles.Add(new Article("Linguagem C#", "linguagem-csharp"));
            articles.Add(new Article("Plataforma .NET", "plataforma-net"));
            Console.WriteLine("Artigos: (Id / Titulo / URL)");
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Id} / {article.Title} / {article.Url}");
            }
            Console.WriteLine();

            var courses = new List<Course>()!;
            courses.Add(new Course("Fundamentos OOP", "fundamentos-oop"));
            courses.Add(new Course("Fundamentos C#", "fundamentos-csharp"));
            courses.Add(new Course("Linguagem C#", "linguagem-csharp"));
            Console.WriteLine("Cursos: (Id / Titulo / URL)");
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id} / {course.Title} / {course.Url}");
            }
            Console.WriteLine();

            var careers = new List<Career>()!;
            var career = new Career("Fundamentos C#", "fundamentos-csharp");
            var careerItem = new CareerItem(1, "Início do Curso", "", courses[0]);
            career.Courses.Add(careerItem);
            careerItem = new CareerItem(2, "Fundamentos Básicos", "", courses[1]);
            career.Courses.Add(careerItem);
            careerItem = new CareerItem(3, "Introdução ao C#", "", courses[2]);
            career.Courses.Add(careerItem);
            careers.Add(career);
            Console.WriteLine("Carreira: (Titulo / Cursos)");
            foreach (var car in careers)
            {
                Console.WriteLine($"{car.Title}");
                foreach (var item in career.Courses.OrderBy(c => c.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course.Title}");

                    Console.WriteLine("Notificações:");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
