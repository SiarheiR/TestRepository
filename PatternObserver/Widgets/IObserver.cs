using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternObserver.Widgets
{
    public interface IObserver
    {
        void Update(string twitter, string lents, string tv);
        void RemoveFromSubject();
    }
}
