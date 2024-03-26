using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CashOnDeliveryPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Оплата {amount} грн готівкою при отриманні...");
        // Логіка оплати готівкою при отриманні
    }
}