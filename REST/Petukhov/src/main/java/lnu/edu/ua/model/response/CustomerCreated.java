package lnu.edu.ua.model.response;

public record CustomerCreated(
        String message,
        String customerId
) {
    public CustomerCreated(String customerId) {
        this("Customer added successfully.", customerId);
    }
}