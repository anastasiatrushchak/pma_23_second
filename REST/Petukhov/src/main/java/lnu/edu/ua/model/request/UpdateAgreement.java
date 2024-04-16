package lnu.edu.ua.model.request;

import java.time.LocalDate;

public record UpdateAgreement(
        LocalDate startDate,
        LocalDate endDate,
        Double costPerDay,
        Long carId,
        Long customerId
) {
}
