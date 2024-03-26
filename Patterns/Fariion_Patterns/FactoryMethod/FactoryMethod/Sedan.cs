using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Sedan : Car
    {
        public override string Drive()
        {
            return "Ви їдете на седані";
        }
    }
}
