package lnu.edu.ua.model.response;

public record CustomerDeleted (
        String message
) {
    public CustomerDeleted() {
        this("Customer deleted successfully.");
    }
}
