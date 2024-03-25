package lnu.edu.ua.facade;

public class Main {

    public static void main(String[] args) {
        PaymentFacade paymentFacade = new PaymentFacade();
        paymentFacade.pay(PaymentSystems.PAYPAL, "test1.com", "test2.com", 100);
    }
}
