using Lab_6.AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.AbstractFactory.Factory
{
    internal class ElectroVehiclesFactory: IVehicleFactory
    {
        private readonly string _type = "electricity";
        public IBus CreateBus(int peopleNumber)
        {
            return new BohdanBus(_type, peopleNumber);
        }

        public ICar CreateCar()
        {
            return new VolvoCar(_type, "...");
        }

        public ITruck CreateTruck(double weigh)
        {
            return new FordTruck(_type, "silent brrrr", weigh);
        }
    }
}
