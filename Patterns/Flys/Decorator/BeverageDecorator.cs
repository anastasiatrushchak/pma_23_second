using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage beverage;
        public BeverageDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public virtual string GetDescription()
        {
            return beverage.GetDescription();
        }
        public virtual double GetCost()
        {
            return beverage.GetCost();
        }
        public override string ToString()
        {
            return $"{GetDescription()} costs {GetCost()}";
        }
    }
}
