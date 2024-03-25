using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class Coffee : Beverage
    {
        public string GetDescription()
        {
            return "Coffee";
        }

        public double GetCost()
        {
            return 40;
        }

        public override string ToString()
        {
            return $"{GetDescription()} costs {GetCost()}";
        }
    }
}
