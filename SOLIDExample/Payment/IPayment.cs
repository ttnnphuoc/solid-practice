namespace SOLIDExample.Payment
{
    #region BAD
    /*
     * Bad :- Single interface that is responsible card and bank payment processing even if someone would be interested in only one
     * Good :- Divide single interface to three different interfaces one to process payment and other two for bank and card
     */
    public interface IPayment1
    {
        void ProcessPayment(decimal amount);
        void EnterCardDetails(string cardNumber, string expiryDate, string cvv);
        void EnterAccountDetails(string accountNumber, string routingNumber);
    }

    public class PaymentService1 : IPayment1
    {
        public void EnterAccountDetails(string accountNumber, string routingNumber) {}

        public void EnterCardDetails(string cardNumber, string expiryDate, string cvv) { }

        public void ProcessPayment(decimal amount) { }
    }
    #endregion

    #region GOOD
    public interface IPayment
    {
        void ProcessPayment(decimal amout);
    }
    
    public interface ICreditCardPayment
    {
        void VerifyCardDetails(string cardNumber, string expiryDate, string cvv);
    }

    public interface IBankTransferPayment
    {
        void VerifyAccountDetails(string accoutNumber, string routingNumber);
    }

    public class CreditCardPaymentService : IPayment, ICreditCardPayment
    {
        public void ProcessPayment(decimal amout) {}
        public void VerifyCardDetails(string cardNumber, string expiryDate, string cvv) {}
    }

    public class BankTransferPaymentService : IPayment, IBankTransferPayment
    {
        public void ProcessPayment(decimal amout){}

        public void VerifyAccountDetails(string accoutNumber, string routingNumber){}
    }
    #endregion
}
