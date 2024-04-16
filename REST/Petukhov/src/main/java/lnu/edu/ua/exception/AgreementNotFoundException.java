package lnu.edu.ua.exception;

public class AgreementNotFoundException extends RuntimeException {
    public AgreementNotFoundException() {
        super("Agreement not found.");
    }
}
