package lnu.edu.ua.facade;

public class Payment {
    private PaymentSystems paymentSystems;
    private String from;
    private String to;
    private int amount;
    private boolean isEncrypted;

    public Payment(PaymentSystems paymentSystems, String from, String to, int amount) {
        this.paymentSystems = paymentSystems;
        this.from = from;
        this.to = to;
        this.amount = amount;
        this.isEncrypted = false;
    }

    public PaymentSystems getPaymentSystems() {
        return paymentSystems;
    }

    public void setPaymentSystems(PaymentSystems paymentSystems) {
        this.paymentSystems = paymentSystems;
    }

    public String getFrom() {
        return from;
    }

    public void setFrom(String from) {
        this.from = from;
    }

    public String getTo() {
        return to;
    }

    public void setTo(String to) {
        this.to = to;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public void setEncrypted(boolean b) {
        this.isEncrypted = b;
    }

    public boolean isEncrypted() {
        return isEncrypted;
    }
}
