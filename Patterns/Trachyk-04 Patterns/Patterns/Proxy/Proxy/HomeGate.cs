using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HomeGate : IHomeGate
{
    public void Open(string username, string password)
    {
        Console.WriteLine($"Opening gate for user: {username}");
        // Реальна логіка відкриття воріт
    }
}
