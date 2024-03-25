package lnu.edu.ua.facade;

public class PaymentFacade {

    public void pay(PaymentSystems paymentSystems, String s, String s1, int i) {
        System.out.println("Creating payment: " + s + " -> " + s1 + " : " + i);
        Payment payment = new Payment(paymentSystems, s, s1, i);
//        Encryptor encryptor = new Encryptor();
//        encryptor.encrypt(payment);
        Sender sender = new Sender();
        sender.sendPayment(payment);
        System.out.printf("Payment sent using %s%n", paymentSystems);
    }
}
