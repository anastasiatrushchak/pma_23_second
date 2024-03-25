using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public interface Beverage
    {
        string GetDescription();
        double GetCost();
    }
}
