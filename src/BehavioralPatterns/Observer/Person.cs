using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Person : /*ISubscriber, */IDisposable
    {
        private readonly NewsPublisher _newsPublisher;

        public Person(NewsPublisher newsPublisher)
        {
            _newsPublisher = newsPublisher;
            //_newsPublisher.SubscribeMe(this);
            _newsPublisher.NewsArrived += HandleNews;
        }

        public void Dispose()
        {
            //_newsPublisher.UnsubscribeMe(this);
            _newsPublisher.NewsArrived -= HandleNews;
        }

        public void HandleNews(string news)
        {
            Console.WriteLine($"Пришла новость {news}");
        }
    }
}
