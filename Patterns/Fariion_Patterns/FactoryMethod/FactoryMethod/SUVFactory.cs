using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class SUVFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new SUV();
        }
    }
}
