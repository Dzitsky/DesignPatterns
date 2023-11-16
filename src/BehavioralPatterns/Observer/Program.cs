using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsPublisher = new NewsPublisher();
            newsPublisher.AddNews("Первая новость!");
            var person = new Person(newsPublisher);
            newsPublisher.AddNews("Вторая новость!");

            Console.ReadKey();
        }
    }
}
