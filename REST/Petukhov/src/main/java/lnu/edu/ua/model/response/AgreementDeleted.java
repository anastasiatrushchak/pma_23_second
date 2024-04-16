package lnu.edu.ua.model.response;

public record AgreementDeleted (String message) {
    public AgreementDeleted() {
        this("Agreement deleted.");
    }
}
