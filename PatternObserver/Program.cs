using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.News;
using PatternObserver.Widgets;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAgregator = new NewsAgregator();
            var twitterWidget = new TwitterWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TVWidget();
            var youTubeWidget = new YouTubeWidget();

            newsAgregator.NewsChanged += twitterWidget.Update;
            newsAgregator.NewsChanged += lentaWidget.Update;
            newsAgregator.NewsChanged += tvWidget.Update;
            newsAgregator.NewsChanged += youTubeWidget.Update;

            newsAgregator.NewNewsAvailable();
            Console.WriteLine();
            newsAgregator.NewNewsAvailable();

            Console.ReadKey();
        }
    }
}
