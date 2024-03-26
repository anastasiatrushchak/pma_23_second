using System;
namespace ConsoleApplication5
{
    public interface IShippingService
    {
        void ShipPackage(string packageId);
    }
    public interface INewShippingService
    {
        void SendPackage(string packageId);
    }
    public class OldShippingService : IShippingService
    {
        public void ShipPackage(string packageId)
        {
            Console.WriteLine($"Shipping package {packageId} via old shipping service.");
        }
    }

    public class ShippingServiceAdapter : INewShippingService
    {
        private readonly IShippingService shippingService;

        public ShippingServiceAdapter(IShippingService shippingService)
        {
            this.shippingService = shippingService;
        }

        public void SendPackage(string packageId)
        {
            shippingService.ShipPackage(packageId);
        }
    }

}