using System;

// Subject interface
interface ISubject
{
    void Request();
}

// Real Subject
class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling request.");
    }
}

// Proxy
class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Proxy: Logging before forwarding request.");
        _realSubject.Request();
        Console.WriteLine("Proxy: Logging after forwarding request.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Client code
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
