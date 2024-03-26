using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GateProxy : IHomeGate
{
    private HomeGate _homeGate;

    public GateProxy()
    {
        _homeGate = new HomeGate();
    }

    public void Open(string username, string password)
    {
        if (username == "admin" && password == "password")
        {
            _homeGate.Open(username, password);
        }
        else
        {
            Console.WriteLine("Access denied. Invalid credentials.");
        }
    }
}
