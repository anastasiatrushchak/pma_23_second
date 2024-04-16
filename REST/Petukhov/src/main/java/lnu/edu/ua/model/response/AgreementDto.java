package lnu.edu.ua.model.response;

import lnu.edu.ua.model.entity.Agreement;
import lnu.edu.ua.model.entity.Car;

import java.time.LocalDate;

public record AgreementDto(
        Long agreement_id,
        LocalDate start_date,
        LocalDate end_date,
        Double cost_per_day,
        CarDto car,
        CustomerDto customer_id
) {
    public AgreementDto(Agreement entity) {
        this (
                entity.getAgreementID(),
                entity.getStartDate(),
                entity.getEndDate(),
                entity.getCostPerDay(),
                new CarDto(entity.getCar()),
                new CustomerDto(entity.getCustomer())
        );
    }
}