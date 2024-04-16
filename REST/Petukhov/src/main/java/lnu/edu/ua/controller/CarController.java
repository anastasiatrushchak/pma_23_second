package lnu.edu.ua.controller;

import jakarta.persistence.EntityNotFoundException;
import jakarta.validation.Valid;
import lnu.edu.ua.exception.CarNotFoundException;
import lnu.edu.ua.model.entity.Car;
import lnu.edu.ua.model.request.NewCar;
import lnu.edu.ua.model.response.CarCreated;
import lnu.edu.ua.model.response.CarDeleted;
import lnu.edu.ua.model.response.CarDto;
import lnu.edu.ua.model.response.CarUpdated;
import lnu.edu.ua.service.CarService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RequiredArgsConstructor
@RestController
@RequestMapping("/car")
public class CarController {
    final CarService carService;

    @GetMapping
    public List<CarDto> getAll() {
        return carService.getAll();
    }

    @GetMapping("/{carID}")
    public CarDto getCarById(@PathVariable Long carID) {
        Car car = carService.getCarById(carID);
        return convertToDto(car);
    }

    @GetMapping(params = "id")
    public CarDto getCarByParam(@RequestParam Long id) {
        Car car = carService.getCarById(id);
        return convertToDto(car);
    }

    @GetMapping(headers = "id")
    public CarDto getCarByHeader(@RequestHeader Long id) {
        Car car = carService.getCarById(id);
        return convertToDto(car);
    }

    @DeleteMapping("/{carID}")
    public CarDeleted deleteCarById(@PathVariable Long carID) {
        try {
            return carService.deleteCarByCarID(carID);
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @DeleteMapping(params = "id")
    public CarDeleted deleteCarByParam(@RequestParam(value = "id", required = false) Long id) {
        try {
            return carService.deleteCarByCarID(id);
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @DeleteMapping(headers = "id")
    public CarDeleted deleteCarByHeader(@RequestHeader(value = "id", required = false) Long id) {
        try {
            return carService.deleteCarByCarID(id);
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PatchMapping("/{id}")
    public CarUpdated updateCar(@PathVariable Long id, @RequestBody NewCar updates) {
        try {
            return carService.updateCar(id, updates);
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PatchMapping(params = {"id", "brand", "type", "color", "seats", "manufacturer"})
    public CarUpdated updateCarByParam(@RequestParam(name = "id") Long id,
                                       @RequestParam(name = "number", required = false) String number,
                                       @RequestParam(name = "brand", required = false) String brand,
                                       @RequestParam(name = "type", required = false) String type,
                                       @RequestParam(name = "color", required = false) String color,
                                       @RequestParam(name = "seats", required = false) Integer seats,
                                       @RequestParam(name = "manufacturer", required = false) String manufacturer) {
        try {
            return carService.updateCar(id, new NewCar(number, brand, type, color, seats, manufacturer));
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PatchMapping(headers = {"id", "number", "brand", "type", "color", "seats", "manufacturer"})
    public CarUpdated updateCarByHeader(@RequestHeader(name = "id") Long id,
                                        @RequestHeader(name = "number", required = false) String number,
                                        @RequestHeader(name = "brand", required = false) String brand,
                                        @RequestHeader(name = "type", required = false) String type,
                                        @RequestHeader(name = "color", required = false) String color,
                                        @RequestHeader(name = "seats", required = false) Integer seats,
                                        @RequestHeader(name = "manufacturer", required = false) String manufacturer) {
        try {
            return carService.updateCar(id, new NewCar(number, brand, type, color, seats, manufacturer));
        } catch (EntityNotFoundException e) {
            throw new CarNotFoundException();
        }
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated create(@Valid @RequestBody NewCar newCar) {
        return carService.create(newCar);
    }

    @PostMapping(params = {"number", "brand", "type", "color", "seats", "manufacturer"})
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated createByParam(@RequestParam String number,
                                    @RequestParam String brand,
                                    @RequestParam String type,
                                    @RequestParam String color,
                                    @RequestParam Integer seats,
                                    @RequestParam String manufacturer) {
        return carService.create(new NewCar(number, brand, type, color, seats, manufacturer));
    }

    @PostMapping(headers = {"number", "brand", "type", "color", "seats", "manufacturer"})
    @ResponseStatus(HttpStatus.CREATED)
    public CarCreated createByHeader(@RequestHeader String number,
                                     @RequestHeader String brand,
                                     @RequestHeader String type,
                                     @RequestHeader String color,
                                     @RequestHeader Integer seats,
                                     @RequestHeader String manufacturer) {
        return carService.create(new NewCar(number, brand, type, color, seats, manufacturer));
    }

    private CarDto convertToDto(Car car) {
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