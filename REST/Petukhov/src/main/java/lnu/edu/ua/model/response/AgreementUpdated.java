package lnu.edu.ua.model.response;

public record AgreementUpdated (
        String message,
        String agreementId
) {
    public AgreementUpdated(String agreementId) {
        this("Agreement updated successfully.", agreementId);
    }
}
