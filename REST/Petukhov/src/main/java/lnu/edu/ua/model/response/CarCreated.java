package lnu.edu.ua.model.response;

public record CarCreated (
        String message,
        String carId
) {
    public CarCreated(String carId) {
        this("Car added successfully.", carId);
    }
}
