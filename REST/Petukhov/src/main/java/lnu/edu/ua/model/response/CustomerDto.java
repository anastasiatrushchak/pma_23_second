package lnu.edu.ua.model.response;

import lnu.edu.ua.model.entity.Customer;

public record CustomerDto (
        Long customerID,
        String number,
        String firstName,
        String lastName,
        String licenseID,
        Integer age,
        String gender

) {
    public CustomerDto(Customer entity) {
        this(
                entity.getCustomerID(),
                entity.getCustomerNumber(),
                entity.getCustomerFirstName(),
                entity.getCustomerLastName(),
                entity.getCustomerLicenseId(),
                entity.getCustomerAge(),
                entity.getCustomerGender()
        );
    }
}
