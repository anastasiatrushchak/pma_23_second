using PatternFaced;
using System;
using System.Text;

namespace PatternFaced
{
   
    public class AccountFacade
    {
        private TransferSubsystem _transferSubsystem;
        private PaymentSubsystem _paymentSubsystem;

        public AccountFacade(TransferSubsystem transferSubsystem, PaymentSubsystem paymentSubsystem)
        {
            _transferSubsystem = transferSubsystem;
            _paymentSubsystem = paymentSubsystem;
        }

        public string PerformTransaction()
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("AccountFacade initiates subsystems:");
            resultBuilder.Append(_transferSubsystem.InitiateTransfer());
            resultBuilder.Append(_paymentSubsystem.InitiatePayment());
            resultBuilder.AppendLine("AccountFacade instructs subsystems to perform the action:");
            resultBuilder.Append(_transferSubsystem.CompleteTransfer());
            resultBuilder.Append(_paymentSubsystem.CompletePayment());
            return resultBuilder.ToString();
        }
    }
}
