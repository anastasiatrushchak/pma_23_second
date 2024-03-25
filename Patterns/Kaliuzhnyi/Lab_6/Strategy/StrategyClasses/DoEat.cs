using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.Strategy.StrategyClasses
{
    internal class DoEat : IDoing
    {
        public void DoSomething()
        {
            Console.WriteLine("I'm eating...");
        }
    }
}
