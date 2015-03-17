using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator.Beverage
{
    public abstract class BeverageBase
    {
        protected string description = "";
        //protected double MilkPrice = 50;
        //protected double SugarPrice = 10;
        //protected double ChokolatePrice = 70;

        //public abstract bool HasMilk();
        //public abstract bool HasSugar();
        //public abstract bool HasChokolate();

        public string GetDescription()
        {
            return description;
        }

        public abstract double GetCost();
    }
}
