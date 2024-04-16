package lnu.edu.ua.service;

import jakarta.validation.Valid;
import lnu.edu.ua.exception.AgreementNotFoundException;
import lnu.edu.ua.exception.CarNotFoundException;
import lnu.edu.ua.exception.CustomerNotFoundException;
import lnu.edu.ua.model.entity.Agreement;
import lnu.edu.ua.model.entity.Car;
import lnu.edu.ua.model.entity.Customer;
import lnu.edu.ua.model.request.*;
import lnu.edu.ua.model.response.*;
import lnu.edu.ua.repository.AgreementRepository;
import lnu.edu.ua.repository.CarRepository;
import lnu.edu.ua.repository.CustomerRepository;
import lombok.RequiredArgsConstructor;
import org.apache.commons.lang3.StringUtils;
import org.hibernate.Hibernate;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import org.apache.commons.lang3.StringUtils;

import java.util.List;

@RequiredArgsConstructor
@Transactional
@Service
public class AgreementService {
    final AgreementRepository agreementRepository;
    final CarRepository carRepository;
    final CustomerRepository customerRepository;

    @Transactional(readOnly = true)
    public List<AgreementDto> getAll() {
        return agreementRepository.findAll().stream()
                .map(AgreementDto::new)
                .toList();
    }

    @Transactional
    public Agreement getByAgreementId(Long agreementID) {
        Agreement agreement = agreementRepository.findByAgreementID(agreementID);
        if (agreement == null) throw new AgreementNotFoundException();

        Hibernate.initialize(agreement.getCar());
        Hibernate.initialize(agreement.getCustomer());

        return agreement;
    }

    public AgreementDeleted deleteAgreementByAgreementID(Long agreementID) {
        Agreement agreement = agreementRepository.findByAgreementID(agreementID);
        if (agreement == null) throw new AgreementNotFoundException();
        agreementRepository.delete(agreement);
        return new AgreementDeleted();
    }

    public AgreementUpdated updateAgreement(Long agreementID, UpdateAgreement updates) {
        Agreement existingAgreement = agreementRepository.findByAgreementID(agreementID);
        if (existingAgreement == null) throw new AgreementNotFoundException();

        if (updates.startDate() != null) {
            existingAgreement.setStartDate(updates.startDate());
        }
        if (updates.endDate() != null) {
            existingAgreement.setEndDate(updates.endDate());
        }
        if (updates.costPerDay() != null) {
            existingAgreement.setCostPerDay(updates.costPerDay());
        }
        if (updates.carId() != null) {
            existingAgreement.setCar(carRepository.findByCarID(updates.carId()));
        }
        if (updates.customerId() != null) {
            existingAgreement.setCustomer(customerRepository.findByCustomerID(updates.customerId()));
        }

        Agreement updatedAgreement = agreementRepository.save(existingAgreement);
        return new AgreementUpdated(updatedAgreement.getAgreementID().toString());
    }

    public AgreementCreated create(NewAgreement newAgreement) {
        Car newAgreementCar = carRepository.findByCarID(newAgreement.carId());
        if (newAgreementCar == null) throw new CarNotFoundException();

        Customer newAgreementCustomer = customerRepository.findByCustomerID(newAgreement.customerId());
        if (newAgreementCustomer == null) throw new CustomerNotFoundException();

        Agreement agreement = Agreement.builder()
                .startDate(newAgreement.startDate())
                .endDate(newAgreement.endDate())
                .costPerDay(newAgreement.costPerDay())
                .car(newAgreementCar)
                .customer(newAgreementCustomer)
                .build();

        Agreement createdAgreement = agreementRepository.save(agreement);
        return new AgreementCreated(createdAgreement.getAgreementID().toString());
    }

    public CustomerUpdated updateCustomer(Long agreementID, NewCustomer customer) {
        Agreement existingAgreement = agreementRepository.findByAgreementID(agreementID);
        if (existingAgreement == null) throw new AgreementNotFoundException();

        Long customerId = existingAgreement.getCustomer().getCustomerID();
        Customer existingCustomer = customerRepository.findByCustomerID(customerId);
        if (existingCustomer == null) throw new CustomerNotFoundException();

        if (StringUtils.isNotBlank(customer.number())) {
            existingCustomer.setCustomerNumber(customer.number());
        }
        if (StringUtils.isNotBlank(customer.firstName())) {
            existingCustomer.setCustomerFirstName(customer.firstName());
        }
        if (StringUtils.isNotBlank(customer.lastName())) {
            existingCustomer.setCustomerLastName(customer.lastName());
        }
        if (StringUtils.isNotBlank(customer.licenseID())) {
            existingCustomer.setCustomerLicenseId(customer.licenseID());
        }
        if (customer.age() != null) {
            existingCustomer.setCustomerAge(customer.age());
        }
        if (StringUtils.isNotBlank(customer.gender())) {
            existingCustomer.setCustomerGender(customer.gender());
        }

        Customer updatedCustomer = customerRepository.save(existingCustomer);
        return new CustomerUpdated(updatedCustomer.getCustomerID().toString());
    }

    public CarUpdated updateCar(Long agreementID, @Valid UpdateCar car) {
        Agreement existingAgreement = agreementRepository.findByAgreementID(agreementID);
        if (existingAgreement == null) throw new AgreementNotFoundException();

        Long carId = existingAgreement.getCar().getCarID();

        Car existingCar = carRepository.findByCarID(carId);
        if (existingCar == null) throw new CustomerNotFoundException();

        if (StringUtils.isNotBlank(car.number())) {
            existingCar.setCarNumber(car.number());
        }
        if (StringUtils.isNotBlank(car.brand())) {
            existingCar.setCarBrand(car.brand());
        }
        if (StringUtils.isNotBlank(car.type())) {
            existingCar.setCarType(car.type());
        }
        if (StringUtils.isNotBlank(car.color())) {
            existingCar.setCarColor(car.color());
        }
        if (car.seats() != null) {
            existingCar.setCarSeats(car.seats());
        }
        if (StringUtils.isNotBlank(car.manufacturer())) {
            existingCar.setCarManufacturer(car.manufacturer());
        }

        Car updatedCar = carRepository.save(existingCar);
        return new CarUpdated(updatedCar.getCarID().toString());
    }

    public Customer getCustomerByAgreementId(Long agreementID) {
        Agreement agreement = agreementRepository.findByAgreementID(agreementID);
        if (agreement == null) throw new AgreementNotFoundException();
        return agreement.getCustomer();
    }

    public Car getCarByAgreementId(Long agreementID) {
        Agreement agreement = agreementRepository.findByAgreementID(agreementID);
        if (agreement == null) throw new AgreementNotFoundException();
        return agreement.getCar();
    }
}
