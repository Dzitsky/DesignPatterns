using System;
using System.Collections.Generic;

namespace Observer
{
    public class NewsPublisher
    {
        private readonly List<string> _news = new List<string>();
        public event Action<string> NewsArrived;

        //private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void AddNews(string news)
        {
            _news.Add(news);
            NewsArrived?.Invoke(news);
            //foreach(ISubscriber subscriber in _subscribers)
            //{
            //    subscriber.HandleNews(news);
            //}
        }

        //public void SubscribeMe(ISubscriber subscriber)
        //{
        //    _subscribers.Add(subscriber);
        //}

        //public void UnsubscribeMe(ISubscriber subscriber)
        //{
        //    _subscribers.Remove(subscriber);
        //}
    }
}
