using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.News;

namespace PatternObserver.Widgets
{
    public class YouTubeWidget : IWidget
    {
        private string _youTube;

        public void Update(object sender, NewsEventArgs e)
        {
            _youTube = e.YouTube;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("YouTube: {0}", _youTube);
        }
    }
}
