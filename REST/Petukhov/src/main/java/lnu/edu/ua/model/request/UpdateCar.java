package lnu.edu.ua.model.request;

import jakarta.validation.Valid;
import jakarta.validation.constraints.NotBlank;
import org.springframework.validation.annotation.Validated;

@Validated
public record UpdateCar(
        String number,
        String brand,
        String type,
        String color,
        Integer seats,
        String manufacturer
) {
}
