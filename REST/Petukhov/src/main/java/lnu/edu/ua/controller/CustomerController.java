package lnu.edu.ua.controller;

import jakarta.persistence.EntityNotFoundException;
import jakarta.validation.Valid;
import lnu.edu.ua.exception.CustomerNotFoundException;
import lnu.edu.ua.model.entity.Customer;
import lnu.edu.ua.model.request.NewCustomer;
import lnu.edu.ua.model.response.CustomerCreated;
import lnu.edu.ua.model.response.CustomerDeleted;
import lnu.edu.ua.model.response.CustomerDto;
import lnu.edu.ua.model.response.CustomerUpdated;
import lnu.edu.ua.service.CustomerService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RequiredArgsConstructor
@RestController
@RequestMapping("/customer")
public class CustomerController {
    final CustomerService customerService;

    @GetMapping
    public List<CustomerDto> getAll() {
        return customerService.getAll();
    }

    @GetMapping("/{customerID}")
    public CustomerDto getCustomerById(@PathVariable Long customerID) {
        Customer customer = customerService.getCustomerById(customerID);
        return convertToDto(customer);
    }

    @GetMapping(params = "id")
    public CustomerDto getCustomerByParam(@RequestParam Long id) {
        Customer customer = customerService.getCustomerById(id);
        return convertToDto(customer);
    }

    @GetMapping(headers = "id")
    public CustomerDto getCarByHeader(@RequestHeader Long id) {
        Customer customer = customerService.getCustomerById(id);
        return convertToDto(customer);
    }

    @DeleteMapping("/{customerID}")
    public CustomerDeleted deleteCustomerById(@PathVariable Long customerID) {
        try {
            return customerService.deleteCustomerByCustomerID(customerID);
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @DeleteMapping(params = "id")
    public CustomerDeleted deleteCustomerByParam(@RequestParam(value = "id", required = false) Long id) {
        try {
            return customerService.deleteCustomerByCustomerID(id);
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @DeleteMapping(headers = "id")
    public CustomerDeleted deleteCustomerByHeader(@RequestHeader(value = "id", required = false) Long id) {
        try {
            return customerService.deleteCustomerByCustomerID(id);
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping("/{id}")
    public CustomerUpdated updateCustomer(@PathVariable Long id, @RequestBody NewCustomer newCustomer) {
        try {
            return customerService.updateCustomer(id, newCustomer);
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping(params = {"id", "number", "firstName", "lastName", "licenseID", "age", "gender"})
    public CustomerUpdated updateCustomerByParam(@RequestParam(name = "id") Long id,
                                                 @RequestParam(name = "number", required = false) String number,
                                                 @RequestParam(name = "firstName", required = false) String firstName,
                                                 @RequestParam(name = "lastName", required = false) String lastName,
                                                 @RequestParam(name = "licenseID", required = false) String licenseID,
                                                 @RequestParam(name = "age", required = false) Integer age,
                                                 @RequestParam(name = "gender", required = false) String gender) {
        try {
            return customerService.updateCustomer(id, new NewCustomer(number, firstName, lastName, licenseID, age, gender));
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping(headers = {"id", "number", "firstName", "lastName", "licenseID", "age", "gender"})
    public CustomerUpdated updateCustomerByHeader(@RequestHeader(name = "id") Long id,
                                                  @RequestHeader(name = "number", required = false) String number,
                                                  @RequestHeader(name = "firstName", required = false) String firstName,
                                                  @RequestHeader(name = "lastName", required = false) String lastName,
                                                  @RequestHeader(name = "licenseID", required = false) String licenseID,
                                                  @RequestHeader(name = "age", required = false) Integer age,
                                                  @RequestHeader(name = "gender", required = false) String gender) {
        try {
            return customerService.updateCustomer(id, new NewCustomer(number, firstName, lastName, licenseID, age, gender));
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated create(@Valid @RequestBody NewCustomer newCustomer) {
        return customerService.create(newCustomer);
    }

    @PostMapping(params = {"number", "firstName", "lastName", "licenseID", "age", "gender"})
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated createByParam(@RequestParam String number,
                                         @RequestParam String firstName,
                                         @RequestParam String lastName,
                                         @RequestParam String licenseID,
                                         @RequestParam Integer age,
                                         @RequestParam String gender) {
        return customerService.create(new NewCustomer(number, firstName, lastName, licenseID, age, gender));
    }

    @PostMapping(headers = {"number", "firstName", "lastName", "licenseID", "age", "gender"})
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated createByHeader(@RequestHeader String number,
                                          @RequestHeader String firstName,
                                          @RequestHeader String lastName,
                                          @RequestHeader String licenseID,
                                          @RequestHeader Integer age,
                                          @RequestHeader String gender) {
        return customerService.create(new NewCustomer(number, firstName, lastName, licenseID, age, gender));
    }

    private CustomerDto convertToDto(Customer customer) {
        return new CustomerDto(
                customer.getCustomerID(),
                customer.getCustomerNumber(),
                customer.getCustomerFirstName(),
                customer.getCustomerLastName(),
                customer.getCustomerLicenseId(),
                customer.getCustomerAge(),
                customer.getCustomerGender()
        );
    }
}
