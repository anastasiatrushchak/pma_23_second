package lnu.edu.ua.facade;

public class Sender {

    public void sendPayment(Payment payment) {
        if (payment.isEncrypted()) {
            System.out.println("Sending encrypted payment: " + payment.getFrom() + " -> " + payment.getTo() + " : " + payment.getAmount());
        } else {
            System.out.println("Payment is not encrypted. Encrypting...");
            Encryptor encryptor = new Encryptor();
            encryptor.encrypt(payment);
        }
    }
}
