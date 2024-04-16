package lnu.edu.ua.model.request;

import org.springframework.validation.annotation.Validated;

@Validated
public record NewCustomer (
        String number,
        String firstName,
        String lastName,
        String licenseID,
        Integer age,
        String gender
) {
}
