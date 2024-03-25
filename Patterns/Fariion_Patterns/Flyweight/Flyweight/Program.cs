using System;
using System.Collections.Generic;


namespace Flyweight;

class Program
{
    static void Main(string[] args)
    {
        CarFactory factory = new CarFactory();

        
        ICarFlyweight car1 = factory.GetCar("Tesla");
        car1.Drive("red");

        
        ICarFlyweight car2 = factory.GetCar("Tesla");
        car2.Drive("black");

        ICarFlyweight car3 = factory.GetCar("Toyota");
        car3.Drive("red");


        ICarFlyweight car4 = factory.GetCar("Toyota");
        car4.Drive("blue");
    }
}
