package lnu.edu.ua.model.response;

public record CarUpdated (String message, String carId) {
    public CarUpdated(String carId) {
        this("Car updated successfully.", carId);
    }
}
