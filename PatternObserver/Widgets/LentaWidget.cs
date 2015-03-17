using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternObserver.News;

namespace PatternObserver.Widgets
{
    public class LentaWidget : IWidget // (IObserver)
    {
        private string _lenta;
        //private ISubject _subject;

        public void Update(object sender, NewsEventArgs e)
        {
            _lenta = e.Lenta;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }

        public void RemoveFromSubject()
        {
            //_subject.RemoveObserver(this);
        }
    }
}
