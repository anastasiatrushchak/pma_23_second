package lnu.edu.ua.service;

import jakarta.persistence.EntityNotFoundException;
import lnu.edu.ua.exception.CarNotFoundException;
import lnu.edu.ua.model.entity.Car;
import lnu.edu.ua.model.request.NewCar;
import lnu.edu.ua.model.response.CarCreated;
import lnu.edu.ua.model.response.CarDeleted;
import lnu.edu.ua.model.response.CarUpdated;
import lnu.edu.ua.repository.AgreementRepository;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.transaction.annotation.Transactional;
import lnu.edu.ua.model.response.CarDto;
import lnu.edu.ua.repository.CarRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Map;

@RequiredArgsConstructor
@Transactional
@Service
public class CarService {
    final CarRepository carRepository;
    final AgreementRepository agreementRepository;

    @Transactional(readOnly = true)
    public List<CarDto> getAll() {
        return carRepository.findAll().stream()
                .map(CarDto::new)
                .toList();
    }

    public Car getCarById(Long carID) {
        Car car = carRepository.findByCarID(carID);
        if (car == null) throw new CarNotFoundException();
        return car;
    }

    public CarDeleted deleteCarByCarID(Long carID) {
        try {
            Car car = carRepository.findByCarID(carID);
            if (car == null) throw new EntityNotFoundException("Car not found with ID: " + carID);
            carRepository.delete(car);
            return new CarDeleted();
        } catch (DataIntegrityViolationException e) {
            throw new DataIntegrityViolationException("Car is used in agreements");
        }
    }

    public CarUpdated updateCar(Long carID, NewCar updates) {
        Car existingCar = carRepository.findByCarID(carID);
        if (existingCar == null) throw new CarNotFoundException();

        if (updates.number() != null) {
            existingCar.setCarNumber(updates.number());
        }
        if (updates.brand() != null) {
            existingCar.setCarBrand(updates.brand());
        }
        if (updates.type() != null) {
            existingCar.setCarType(updates.type());
        }
        if (updates.color() != null) {
            existingCar.setCarColor(updates.color());
        }
        if (updates.seats() != null) {
            existingCar.setCarSeats(updates.seats());
        }
        if (updates.manufacturer() != null) {
            existingCar.setCarManufacturer(updates.manufacturer());
        }

        Car updatedCar = carRepository.save(existingCar);
        return new CarUpdated(updatedCar.getCarID().toString());
    }

    public CarCreated create(NewCar newCar) {
        Car car = Car.builder()
                .carNumber(newCar.number())
                .carBrand(newCar.brand())
                .carType(newCar.type())
                .carColor(newCar.color())
                .carSeats(newCar.seats())
                .carManufacturer(newCar.manufacturer())
                .build();
        car = carRepository.save(car);
        return new CarCreated(car.getCarID().toString());
    }
}
