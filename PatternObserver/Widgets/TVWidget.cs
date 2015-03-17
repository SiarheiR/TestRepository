using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.News;

namespace PatternObserver.Widgets
{
    public class TVWidget : IWidget // (IObserver)
    {
        private string _tv;
        //private ISubject _subject;

        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.TV;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }

        public void RemoveFromSubject()
        {
            //_subject.RemoveObserver(this);
        }
    }
}
