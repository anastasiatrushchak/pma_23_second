using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} with Milk";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 10;
        }
    }
}
