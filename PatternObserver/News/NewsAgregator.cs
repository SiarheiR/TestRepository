using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.Widgets;

namespace PatternObserver.News
{
    public class NewsEventArgs
    {
        public string Twitter { get; private set; }
        public string Lenta { get; private set; }
        public string TV { get; private set; }
        public string YouTube { get; private set; }

        public NewsEventArgs(string twitter, string lenta, string tv, string youTube)
        {
            Twitter = twitter;
            Lenta = lenta;
            TV = tv;
            YouTube = youTube;
        }
    }

    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);

    public class NewsAgregator
    {
        private static Random _random;

        public NewsAgregator()
        {
            _random = new Random();
        }

        public event NewsChangedEventHandler NewsChanged;

        public string GetTwitterNews()
        {
            var news = new List<string>
            {
                "Twitter news 1",
                "Twitter news 2",
                "Twitter news 3"
            };

            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<string>
            {
                "Lenta news 1",
                "Lenta news 2",
                "Lenta news 3"
            };

            return news[_random.Next(3)];
        }

        public string GetTVNews()
        {
            var news = new List<string>
            {
                "TV news 1",
                "TV news 2",
                "TV news 3"
            };

            return news[_random.Next(3)];
        }

        public string GetYouTubeNews()
        {
            var news = new List<string>
            {
                "YouTube news 1",
                "YouTube news 2",
                "YouTube news 3"
            };

            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            string twitter = GetTwitterNews();
            string lenta = GetLentaNews();
            string tv = GetTVNews();
            string youTube = GetYouTubeNews();

            if (NewsChanged != null)
                NewsChanged(this, new NewsEventArgs(twitter, lenta, tv, youTube));
        }
    }
}
