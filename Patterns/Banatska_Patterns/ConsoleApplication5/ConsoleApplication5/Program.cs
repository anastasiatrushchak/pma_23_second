using System;
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            IShippingService shippingService = new OldShippingService();

            INewShippingService adapter = new ShippingServiceAdapter(shippingService);

            Client client = new Client(adapter);

            client.SendPackage("12345");
        }
    }

}