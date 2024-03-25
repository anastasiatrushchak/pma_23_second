package lnu.edu.ua.facade;

public class Encryptor {

    public void encrypt(Payment payment) {
        payment.setEncrypted(true);
        System.out.println("Encrypting payment: " + payment.getFrom() + " -> " + payment.getTo() + " : " + payment.getAmount());
    }
}
