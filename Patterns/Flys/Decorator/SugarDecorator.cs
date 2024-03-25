using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} with Sugar";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 5;
        }
    }
}
