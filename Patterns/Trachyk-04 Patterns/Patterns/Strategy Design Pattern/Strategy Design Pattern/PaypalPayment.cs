using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PaypalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Оплата {amount} грн через PayPal...");
        // Логіка оплати через PayPal
    }
}