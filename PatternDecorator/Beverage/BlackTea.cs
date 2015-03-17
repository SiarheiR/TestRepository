using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator.Beverage
{
    class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            description = "Black Tea Desc";
        }
        public override double GetCost()
        {
            return 100;
        }
    }
}
