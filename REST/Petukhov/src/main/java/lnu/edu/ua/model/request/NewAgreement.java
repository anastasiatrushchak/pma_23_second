package lnu.edu.ua.model.request;

import jakarta.validation.constraints.Future;
import jakarta.validation.constraints.FutureOrPresent;
import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotNull;
import org.springframework.validation.annotation.Validated;

import java.time.LocalDate;

@Validated
public record NewAgreement (
        @FutureOrPresent @NotNull LocalDate startDate,
        @FutureOrPresent @NotNull LocalDate endDate,
        @Min(0) @NotNull Double costPerDay,
        @NotNull Long carId,
        @NotNull Long customerId
) {

}
