using System;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Другая часть клиентского кода создает саму цепочку.
            var buyer = new BuyerHandler();
            var seller = new SellerHandler();
            var wholesaler = new WholesalerHandler();

            buyer.SetNext(seller).SetNext(wholesaler);

            // Клиент должен иметь возможность отправлять запрос любому
            // обработчику, а не только первому в цепочке.
            Console.WriteLine("Chain: Buyer > Seller > Wholesaler\n");
            Client.ClientCode(buyer);
            Console.WriteLine();

            Console.WriteLine("Subchain: Seller > Wholesaler\n");
            Client.ClientCode(seller);
        }
    }
}
