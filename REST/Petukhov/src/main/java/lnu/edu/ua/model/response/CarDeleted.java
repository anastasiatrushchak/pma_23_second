package lnu.edu.ua.model.response;

public record CarDeleted (String message) {
    public CarDeleted() {
        this("Car deleted.");
    }
}
