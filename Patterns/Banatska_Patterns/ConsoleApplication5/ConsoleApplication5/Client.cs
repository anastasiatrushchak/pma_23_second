namespace ConsoleApplication5
{
    public class Client
    {
        private readonly INewShippingService newShippingService;

        public Client(INewShippingService newShippingService)
        {
            this.newShippingService = newShippingService;
        }

        public void SendPackage(string packageId)
        {
            newShippingService.SendPackage(packageId);
        }
    }


}