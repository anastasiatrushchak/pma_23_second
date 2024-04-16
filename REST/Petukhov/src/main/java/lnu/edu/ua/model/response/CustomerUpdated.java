package lnu.edu.ua.model.response;

public record CustomerUpdated (
        String message,
        String customerId
) {
    public CustomerUpdated(String customerId) {
        this("Client updated successfully.", customerId);
    }
}