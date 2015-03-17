using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternDecorator.Beverage;

namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase capuccino = new Capuccino();
            BeverageBase blackTea = new BlackTea();
            BeverageBase espresso = new Espresso();
            BeverageBase hotChokolate = new HotChokolate();

            Console.WriteLine(capuccino.GetDescription() + " " + capuccino.GetCost());
            Console.WriteLine(blackTea.GetDescription() + " " + blackTea.GetCost());
            Console.WriteLine(espresso.GetDescription() + " " + espresso.GetCost());
            Console.WriteLine(hotChokolate.GetDescription() + " " + hotChokolate.GetCost());


            Console.ReadKey();
        }
    }
}
