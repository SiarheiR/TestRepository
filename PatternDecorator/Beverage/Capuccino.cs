using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator.Beverage
{
    class Capuccino : BeverageBase
    {
        public Capuccino()
        {
            description = "Capuccino Desc";
        }
        public override double GetCost()
        {
            return 200;
        }
    }
}
