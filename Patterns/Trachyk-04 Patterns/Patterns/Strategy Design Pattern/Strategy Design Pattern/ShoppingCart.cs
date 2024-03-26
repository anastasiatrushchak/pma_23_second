using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void Checkout(double amount)
    {
        this.paymentStrategy.Pay(amount);
    }
}
