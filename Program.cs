using System;
using Oop.ContentContext;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>()!;
            articles.Add(new Article("Orientação a Objetos", "orientacao-objetos"));
            articles.Add(new Article("Linguagem C#", "linguagem-csharp"));
            articles.Add(new Article("Plataforma .NET", "plataforma-net"));
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Artigos:");
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            Console.WriteLine();
        }
    }
}
