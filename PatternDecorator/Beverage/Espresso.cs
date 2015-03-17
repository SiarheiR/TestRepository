using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator.Beverage
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            description = "Espresso Desc";
        }

        public override double GetCost()
        {
            return 100;
        }
    }
}
