using System;

class Program
{
    static void Main(string[] args)
    {
        // Вибір способу оплати
        Console.WriteLine("Оберiть спосiб оплати: (1) Кредитна карта, (2) PayPal, (3) Готiвкою при отриманнi:");
        string paymentMethod = Console.ReadLine();

        IPaymentStrategy paymentStrategy;
        switch (paymentMethod)
        {
            case "1":
                paymentStrategy = new CreditCardPayment();
                break;
            case "2":
                paymentStrategy = new PaypalPayment();
                break;
            case "3":
                paymentStrategy = new CashOnDeliveryPayment();
                break;
            default:
                Console.WriteLine("Невiрно вибраний спосiб оплати.");
                return;
        }

        // Проведення оплати
        ShoppingCart cart = new ShoppingCart(paymentStrategy);
        cart.Checkout(1000); // Припустимо, що сума покупки - 1000 грн
    }
}