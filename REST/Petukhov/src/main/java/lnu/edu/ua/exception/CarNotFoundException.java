package lnu.edu.ua.exception;

public class CarNotFoundException extends RuntimeException {
    public CarNotFoundException() {
        super("Car not found.");
    }
}
