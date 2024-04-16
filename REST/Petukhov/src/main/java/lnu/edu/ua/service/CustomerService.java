package lnu.edu.ua.service;

import lnu.edu.ua.exception.CustomerNotFoundException;
import lnu.edu.ua.model.entity.Customer;
import lnu.edu.ua.model.request.NewCustomer;
import lnu.edu.ua.model.response.CustomerCreated;
import lnu.edu.ua.model.response.CustomerDeleted;
import lnu.edu.ua.model.response.CustomerDto;
import lnu.edu.ua.model.response.CustomerUpdated;
import lnu.edu.ua.repository.AgreementRepository;
import lnu.edu.ua.repository.CustomerRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@RequiredArgsConstructor
@Transactional
@Service
public class CustomerService {
    final CustomerRepository customerRepository;
    final AgreementRepository agreementRepository;

    @Transactional(readOnly = true)
    public List<CustomerDto> getAll() {
        return customerRepository.findAll().stream()
                .map(CustomerDto::new)
                .toList();
    }

    public Customer getCustomerById(Long customerID) {
        Customer customer = customerRepository.findByCustomerID(customerID);
        if (customer == null) throw new CustomerNotFoundException();
        return customer;
    }

    public CustomerDeleted deleteCustomerByCustomerID(Long customerID) {
        try {
            Customer customer = customerRepository.findByCustomerID(customerID);
            if (customer == null) throw new CustomerNotFoundException();
            customerRepository.delete(customer);
            return new CustomerDeleted();
        } catch (DataIntegrityViolationException e) {
            throw new DataIntegrityViolationException("Customer is used in agreements");
        }
    }

    public CustomerUpdated updateCustomer(Long customerID, NewCustomer updates) {
        Customer existingCustomer = customerRepository.findByCustomerID(customerID);
        if (existingCustomer == null) throw new CustomerNotFoundException();

        if (updates.number() != null) {
            existingCustomer.setCustomerNumber(updates.number());
        }
        if (updates.firstName() != null) {
            existingCustomer.setCustomerFirstName(updates.firstName());
        }
        if (updates.lastName() != null) {
            existingCustomer.setCustomerLastName(updates.lastName());
        }
        if (updates.licenseID() != null) {
            existingCustomer.setCustomerLicenseId(updates.licenseID());
        }
        if (updates.age() != null) {
            existingCustomer.setCustomerAge(updates.age());
        }
        if (updates.gender() != null) {
            existingCustomer.setCustomerGender(updates.gender());
        }

        Customer updatedCustomer = customerRepository.save(existingCustomer);
        return new CustomerUpdated(updatedCustomer.getCustomerID().toString());
    }

    public CustomerCreated create(NewCustomer newCustomer) {
        Customer customer = Customer.builder()
                .customerNumber(newCustomer.number())
                .customerFirstName(newCustomer.firstName())
                .customerLastName(newCustomer.lastName())
                .customerLicenseId(newCustomer.licenseID())
                .customerAge(newCustomer.age())
                .customerGender(newCustomer.gender())
                .build();
        customer = customerRepository.save(customer);
        return new CustomerCreated(customer.getCustomerID().toString());
    }
}
