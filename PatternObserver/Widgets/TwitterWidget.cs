using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.News;

namespace PatternObserver.Widgets
{
    public class TwitterWidget : IWidget // (IObserver)
    {
        private string _twitter;

        public void Update(object sender, NewsEventArgs e)
        {
            _twitter = e.Twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", _twitter);
        }
    }
}
