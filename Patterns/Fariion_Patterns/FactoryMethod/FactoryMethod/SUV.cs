using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class SUV : Car
    {
        public override string Drive()
        {
            return "Ви їдете на великому кросовері";
        }
    }
}
