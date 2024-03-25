using System;


namespace CommandDesignPattern_;


class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        ICommand startCommand = new EngineStartCommand(car);
        ICommand stopCommand = new EngineStopCommand(car);
        Driver driver = new Driver();

        
        driver.SetCommand(startCommand);
        driver.ExecuteCommand();

        driver.SetCommand(stopCommand);
        driver.ExecuteCommand();
    }
}
