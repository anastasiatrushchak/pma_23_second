using System;

interface IPaymentSystem
{
    bool CheckBalance(decimal amount);
    void ProcessPayment(decimal amount);
}

class BankPaymentSystem : IPaymentSystem
{
    public bool CheckBalance(decimal amount)
    {
        return true;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата здійснена через банківську систему на суму {amount} грн");
    }
}

class PaymentSystemProxy : IPaymentSystem
{
    private IPaymentSystem realPaymentSystem;

    public PaymentSystemProxy(IPaymentSystem paymentSystem)
    {
        realPaymentSystem = paymentSystem;
    }

    public bool CheckBalance(decimal amount)
    {
        Console.WriteLine("Перевірка балансу...");
        return realPaymentSystem.CheckBalance(amount);
    }

    public void ProcessPayment(decimal amount)
    {
        try
        {
            if (CheckBalance(amount))
            {
                realPaymentSystem.ProcessPayment(amount);
            }
            else
            {
                Console.WriteLine("Недостатньо коштів на рахунку для здійснення оплати.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка під час оплати: {ex.Message}");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        IPaymentSystem bankPaymentSystem = new BankPaymentSystem();

        PaymentSystemProxy paymentProxy = new PaymentSystemProxy(bankPaymentSystem);

        Console.WriteLine("Введіть суму для оплати:");
        if (decimal.TryParse(Console.ReadLine(), out decimal paymentAmount))
        {
            decimal maximumAllowedAmount = 1000; 
            if (paymentAmount <= maximumAllowedAmount)
            {
                paymentProxy.ProcessPayment(paymentAmount);
            }
            else
            {
                Console.WriteLine("Сума для оплати перевищує максимально допустиму суму.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне значення для суми оплати.");
        }
    }
}
