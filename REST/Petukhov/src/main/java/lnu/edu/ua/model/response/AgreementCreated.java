package lnu.edu.ua.model.response;

public record AgreementCreated (
        String message,
        String agreementId
) {
    public AgreementCreated(String agreementId) {
        this("Agreement added successfully.", agreementId);
    }
}
