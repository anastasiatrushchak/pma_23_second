using System;

namespace pattern
{
   
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: What drinks can you recomend me from first cafe?");
            ClientMethod(new CafeFactory1());
            Console.WriteLine();

            Console.WriteLine("Client:What drinks can you recomend me from second cafe? ");
            ClientMethod(new CafeFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var hotDrink = factory.CreateHotDrink();
            var coldDrink = factory.CreateColdDrink();

            Console.WriteLine(hotDrink.ServeHot());
            Console.WriteLine(coldDrink.ServeCold());
        }
    }
}
