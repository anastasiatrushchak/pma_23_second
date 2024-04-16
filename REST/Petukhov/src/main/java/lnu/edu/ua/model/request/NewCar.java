package lnu.edu.ua.model.request;

import org.springframework.validation.annotation.Validated;

@Validated
public record NewCar(
        String number,
        String brand,
        String type,
        String color,
        Integer seats,
        String manufacturer
) {
}
