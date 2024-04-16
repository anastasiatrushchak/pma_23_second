package lnu.edu.ua.controller;

import jakarta.persistence.EntityNotFoundException;
import jakarta.validation.Valid;
import lnu.edu.ua.exception.AgreementNotFoundException;
import lnu.edu.ua.exception.CarNotFoundException;
import lnu.edu.ua.exception.CustomerNotFoundException;
import lnu.edu.ua.model.entity.Agreement;
import lnu.edu.ua.model.entity.Car;
import lnu.edu.ua.model.entity.Customer;
import lnu.edu.ua.model.request.*;
import lnu.edu.ua.model.response.*;
import lnu.edu.ua.service.AgreementService;
import lnu.edu.ua.service.CarService;
import lnu.edu.ua.service.CustomerService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDate;
import java.util.List;
import java.util.Objects;

@RequiredArgsConstructor
@RestController
@RequestMapping("/agreement")
public class AgreementController {
    private final AgreementService agreementService;
    private final CustomerService customerService;
    private final CarService carService;

    @GetMapping
    public List<AgreementDto> getAll() {
        return agreementService.getAll();
    }

    @GetMapping("/customer")
    public List<CustomerDto> getAllCustomers() {
        return customerService.getAll();
    }

    @GetMapping("/car")
    public List<CarDto> getAllCars() {
        return carService.getAll();
    }

    @GetMapping("/{agreementID}")
    public AgreementDto getAgreementById(@PathVariable Long agreementID) {
        Agreement agreement = agreementService.getByAgreementId(agreementID);
        return convertToDto(agreement);
    }

    @GetMapping("/customer/{customerID}")
    public CustomerDto getCustomerById(@PathVariable Long customerID) {
        Customer customer = customerService.getCustomerById(customerID);
        return convertToCustomerDto(customer);
    }

    @GetMapping("/car/{carID}")
    public CarDto getCarById(@PathVariable Long carID) {
        Car car = carService.getCarById(carID);
        return convertToCarDto(car);
    }

    @GetMapping(params = "id")
    public AgreementDto getAgreementByParam(@RequestParam Long id) {
        Agreement agreement = agreementService.getByAgreementId(id);
        return convertToDto(agreement);
    }

    @GetMapping(path = "/customer", params = "id")
    public CustomerDto getCustomerByParam(@RequestParam Long id) {
        Customer customer = customerService.getCustomerById(id);
        return convertToCustomerDto(customer);
    }

    @GetMapping(path = "/car", params = "id")
    public CarDto getCarByParam(@RequestParam Long id) {
        Car car = carService.getCarById(id);
        return convertToCarDto(car);
    }

    @GetMapping(headers = "id")
    public AgreementDto getAgreementByHeader(@RequestHeader Long id) {
        Agreement agreement = agreementService.getByAgreementId(id);
        return convertToDto(agreement);
    }

    @GetMapping(path = "/customer", headers = "id")
    public CustomerDto getCustomerByHeader(@RequestHeader Long id) {
        Customer customer = customerService.getCustomerById(id);
        return convertToCustomerDto(customer);
    }

    @GetMapping(path = "/car", headers = "id")
    public CarDto getCarByHeader(@RequestHeader Long id) {
        Car car = carService.getCarById(id);
        return convertToCarDto(car);
    }

    @Transactional(readOnly = true)
    @GetMapping("/{agreementID}/customer")
    public CustomerDto getCustomerByAgreementId(@PathVariable Long agreementID) {
        Customer customer = agreementService.getCustomerByAgreementId(agreementID);
        return convertToCustomerDto(customer);
    }

    @Transactional(readOnly = true)
    @GetMapping("/{agreementID}/car")
    public CarDto getCarByAgreementId(@PathVariable Long agreementID) {
        Car car = agreementService.getCarByAgreementId(agreementID);
        return convertToCarDto(car);
    }

    @DeleteMapping("/{agreementID}")
    public AgreementDeleted deleteAgreementById(@PathVariable Long agreementID) {
        try {
            return agreementService.deleteAgreementByAgreementID(agreementID);
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @DeleteMapping(params = "id")
    public AgreementDeleted deleteAgreementByParam(@RequestParam(value = "id", required = false) Long id) {
        try {
            return agreementService.deleteAgreementByAgreementID(id);
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @DeleteMapping(headers = "id")
    public AgreementDeleted deleteAgreementByHeader(@RequestHeader(value = "id", required = false) Long id) {
        try {
            return agreementService.deleteAgreementByAgreementID(id);
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @PatchMapping("/{agreementID}")
    public AgreementUpdated updateAgreement(@PathVariable Long agreementID,
                                            @RequestBody @Valid UpdateAgreement agreementDto) {
        try {
            return agreementService.updateAgreement(agreementID, agreementDto);
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @PatchMapping(headers = {"id", "startDate", "endDate", "costPerDay", "carID", "customerID"})
    public AgreementUpdated agreementUpdated(@RequestHeader(name = "id") Long id,
                                             @RequestHeader(name = "startDate", required = false) String startDate,
                                             @RequestHeader(name = "endDate", required = false) String endDate,
                                             @RequestHeader(name = "costPerDay", required = false) Double costPerDay,
                                             @RequestHeader(name = "carID", required = false) Long carID,
                                             @RequestHeader(name = "customerID", required = false) Long customerID) {
        LocalDate parsedStartDate = !Objects.equals(startDate, "") ? LocalDate.parse(startDate) : null;
        LocalDate parsedEndDate = !Objects.equals(endDate, "") ? LocalDate.parse(endDate) : null;

        try {
            return agreementService.updateAgreement(id, new UpdateAgreement(
                    parsedStartDate,
                    parsedEndDate,
                    costPerDay,
                    carID,
                    customerID)
            );
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @PatchMapping(params = {"id", "startDate", "endDate", "costPerDay", "carID", "customerID"})
    public AgreementUpdated agreementUpdatedParam(@RequestParam(name = "id") Long id,
                                                  @RequestParam(name = "startDate", required = false) String startDate,
                                                  @RequestParam(name = "endDate", required = false) String endDate,
                                                  @RequestParam(name = "costPerDay", required = false) Double costPerDay,
                                                  @RequestParam(name = "carID", required = false) Long carID,
                                                  @RequestParam(name = "customerID", required = false) Long customerID) {
        LocalDate parsedStartDate = !Objects.equals(startDate, "") ? LocalDate.parse(startDate) : null;
        LocalDate parsedEndDate = !Objects.equals(endDate, "") ? LocalDate.parse(endDate) : null;

        try {
            return agreementService.updateAgreement(id, new UpdateAgreement(
                    parsedStartDate,
                    parsedEndDate,
                    costPerDay,
                    carID,
                    customerID)
            );
        } catch (EntityNotFoundException e) {
            throw new AgreementNotFoundException();
        }
    }

    @PatchMapping("/{agreementID}/customer")
    public CustomerUpdated updateCustomer(@PathVariable Long agreementID, @RequestBody NewCustomer customer) {
        try {
            return agreementService.updateCustomer(agreementID, customer);
        } catch (AgreementNotFoundException e) {
            throw new AgreementNotFoundException();
        } catch (CustomerNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping(params = {"id", "number", "firstName", "lastName", "licenseID", "age", "gender"}, path = "/customer")
    public CustomerUpdated updateCustomerByParam(@RequestParam(name = "id") Long id,
                                                 @RequestParam(name = "number", required = false) String number,
                                                 @RequestParam(name = "firstName", required = false) String firstName,
                                                 @RequestParam(name = "lastName", required = false) String lastName,
                                                 @RequestParam(name = "licenseID", required = false) String licenseID,
                                                 @RequestParam(name = "age", required = false) Integer age,
                                                 @RequestParam(name = "gender", required = false) String gender) {
        try {
            return agreementService.updateCustomer(id, new NewCustomer(number, firstName, lastName, licenseID, age, gender));
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping(headers = {"id", "number", "firstName", "lastName", "licenseID", "age", "gender"}, path = "/customer")
    public CustomerUpdated updateCustomerByHeader(@RequestHeader(name = "id") Long id,
                                                  @RequestHeader(name = "number", required = false) String number,
                                                  @RequestHeader(name = "firstName", required = false) String firstName,
                                                  @RequestHeader(name = "lastName", required = false) String lastName,
                                                  @RequestHeader(name = "licenseID", required = false) String licenseID,
                                                  @RequestHeader(name = "age", required = false) Integer age,
                                                  @RequestHeader(name = "gender", required = false) String gender) {
        try {
            return agreementService.updateCustomer(id, new NewCustomer(number, firstName, lastName, licenseID, age, gender));
        } catch (EntityNotFoundException e) {
            throw new CustomerNotFoundException();
        }
    }

    @PatchMapping("/{agreementID}/car")
    public CarUpdated updateCar(@PathVariable Long agreementID, @RequestBody @Valid UpdateCar car) {
        try {
            return agreementService.updateCar(agreementID, car);
        } catch (AgreementNotFoundException e) {
            throw new AgreementNotFoundException();
        } catch (CarNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PatchMapping(params = {"id", "number", "brand", "type", "color", "seats", "manufacturer"}, path = "/car")
    public CarUpdated updateCarByParam(@RequestParam(name = "id") Long id,
                                       @RequestParam(name = "number", required = false) String number,
                                       @RequestParam(name = "brand", required = false) String brand,
                                       @RequestParam(name = "type", required = false) String type,
                                       @RequestParam(name = "color", required = false) String color,
                                       @RequestParam(name = "seats", required = false) Integer seats,
                                       @RequestParam(name = "manufacturer", required = false) String manufacturer) {
        try {
            return agreementService.updateCar(id, new UpdateCar(number, brand, type, color, seats, manufacturer));
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PatchMapping(headers = {"id", "number", "brand", "type", "color", "seats", "manufacturer"}, path = "/car")
    public CarUpdated updateCarByHeader(@RequestHeader(name = "id") Long id,
                                        @RequestHeader(name = "number", required = false) String number,
                                        @RequestHeader(name = "brand", required = false) String brand,
                                        @RequestHeader(name = "type", required = false) String type,
                                        @RequestHeader(name = "color", required = false) String color,
                                        @RequestHeader(name = "seats", required = false) Integer seats,
                                        @RequestHeader(name = "manufacturer", required = false) String manufacturer) {
        try {
            return agreementService.updateCar(id, new UpdateCar(number, brand, type, color, seats, manufacturer));
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public AgreementCreated create(@RequestBody @Valid NewAgreement agreementDto) {
        return agreementService.create(agreementDto);
    }

    @PostMapping(params = {"startDate", "endDate", "costPerDay", "carID", "customerID"})
    @ResponseStatus(HttpStatus.CREATED)
    public AgreementCreated createAgreementWithParam(@RequestParam(name = "startDate") String startDate,
                                                     @RequestParam(name = "endDate") String endDate,
                                                     @RequestParam(name = "costPerDay") Double costPerDay,
                                                     @RequestParam(name = "carID") Long carID,
                                                     @RequestParam(name = "customerID") Long customerID) {
        LocalDate parsedStartDate = LocalDate.parse(startDate);
        LocalDate parsedEndDate = LocalDate.parse(endDate);

        return agreementService.create(new NewAgreement(
                parsedStartDate,
                parsedEndDate,
                costPerDay,
                carID,
                customerID)
        );
    }

    @PostMapping(headers = {"startDate", "endDate", "costPerDay", "carID", "customerID"})
    @ResponseStatus(HttpStatus.CREATED)
    public AgreementCreated createAgreementWithHeader(@RequestHeader(name = "startDate") String startDate,
                                                      @RequestHeader(name = "endDate") String endDate,
                                                      @RequestHeader(name = "costPerDay") Double costPerDay,
                                                      @RequestHeader(name = "carID") Long carID,
                                                      @RequestHeader(name = "customerID") Long customerID) {
        LocalDate parsedStartDate = LocalDate.parse(startDate);
        LocalDate parsedEndDate = LocalDate.parse(endDate);

        return agreementService.create(new NewAgreement(
                parsedStartDate,
                parsedEndDate,
                costPerDay,
                carID,
                customerID)
        );
    }

    @PostMapping("/customer")
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated createAgreementCustomer(@RequestBody NewCustomer customer) {
        return customerService.create(customer);
    }

    @PostMapping(params = {"number", "firstName", "lastName", "licenseID", "age", "gender"}, path = "/customer")
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated createAgreementCustomerWithParameter(@RequestParam String number,
                                                                @RequestParam String firstName,
                                                                @RequestParam String lastName,
                                                                @RequestParam String licenseID,
                                                                @RequestParam Integer age,
                                                                @RequestParam String gender) {
        return customerService.create(new NewCustomer(number, firstName, lastName, licenseID, age, gender));
    }

    @PostMapping(headers = {"number", "firstName", "lastName", "licenseID", "age", "gender"}, path = "/customer")
    @ResponseStatus(HttpStatus.CREATED)
    public CustomerCreated createAgreementCustomerWithHeader(@RequestHeader String number,
                                                             @RequestHeader String firstName,
                                                             @RequestHeader String lastName,
                                                             @RequestHeader String licenseID,
                                                             @RequestHeader Integer age,
                                                             @RequestHeader String gender) {
        return customerService.create(new NewCustomer(number, firstName, lastName, licenseID, age, gender));
    }

    @PostMapping("/car")
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated createAgreementCar(@RequestBody NewCar car) {
        return carService.create(car);
    }

    @PostMapping(params = {"number", "brand", "type", "color", "seats", "manufacturer"}, path = "/car")
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated createAgreementCarWithParameter(@RequestParam String number,
                                                      @RequestParam String brand,
                                                      @RequestParam String type,
                                                      @RequestParam String color,
                                                      @RequestParam Integer seats,
                                                      @RequestParam String manufacturer) {
        return carService.create(new NewCar(number, brand, type, color, seats, manufacturer));
    }

    @PostMapping(headers = {"number", "brand", "type", "color", "seats", "manufacturer"}, path = "/car")
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated createAgreementCarWithHeader(@RequestHeader String number,
                                                   @RequestHeader String brand,
                                                   @RequestHeader String type,
                                                   @RequestHeader String color,
                                                   @RequestHeader Integer seats,
                                                   @RequestHeader String manufacturer) {
        return carService.create(new NewCar(number, brand, type, color, seats, manufacturer));
    }

    private AgreementDto convertToDto(Agreement agreement) {
        CarDto carDto = new CarDto(agreement.getCar());
        CustomerDto customerDto = new CustomerDto(agreement.getCustomer());

        return new AgreementDto(
                agreement.getAgreementID(),
                agreement.getStartDate(),
                agreement.getEndDate(),
                agreement.getCostPerDay(),
                carDto,
                customerDto
        );
    }

    private CustomerDto convertToCustomerDto(Customer customer) {
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

    private CarDto convertToCarDto(Car car) {

        return new CarDto(
                car.getCarID(),
                car.getCarNumber(),
                car.getCarBrand(),
                car.getCarType(),
                car.getCarColor(),
                car.getCarSeats(),
                car.getCarManufacturer()
        );
    }
}