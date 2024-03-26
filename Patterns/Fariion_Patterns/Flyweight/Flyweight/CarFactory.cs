using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CarFactory
    {
        private Dictionary<string, ICarFlyweight> cars = new Dictionary<string, ICarFlyweight>();

        public ICarFlyweight GetCar(string brand)
        {
            if (!cars.ContainsKey(brand))
            {
                cars[brand] = new Car(brand);
            }
            return cars[brand];
        }
    }
}
