using System;

namespace PatternFaced
{
    class Client
    {
        public static void Main(string[] args)
        {
            
            TransferSubsystem transferSubsystem = new TransferSubsystem();
            PaymentSubsystem paymentSubsystem = new PaymentSubsystem();

         
            AccountFacade accountFacade = new AccountFacade(transferSubsystem, paymentSubsystem);

            Console.WriteLine(Client.ClientCode(accountFacade));
        }

        
        public static string ClientCode(AccountFacade facade)
        {
            return facade.PerformTransaction();
        }
    }
}
