using System;

class Program
{
    static void Main(string[] args)
    {
        IHomeGate gate = new GateProxy();
        
        // Спроба відкрити ворота з користувачем і паролем
        gate.Open("admin", "password"); // Відкрито ворота

        // Спроба відкрити ворота з неправильними користувачем і паролем
        gate.Open("user", "123456"); // Відмовлено в доступі

        Console.ReadLine();
    }
}
