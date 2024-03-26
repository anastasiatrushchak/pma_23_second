using Lab_6.AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.AbstractFactory.Factory
{
    internal interface IVehicleFactory
    {
        ICar CreateCar();
        
        ITruck CreateTruck(double weigh);

        IBus CreateBus(int peopleNumber);
    }
}
