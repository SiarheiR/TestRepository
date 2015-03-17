using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator.Beverage
{
    class HotChokolate : BeverageBase
    {
        public HotChokolate()
        {
            description = "HotChokolate";
        }

        public override double GetCost()
        {
            return 150;
        }
    }
}
