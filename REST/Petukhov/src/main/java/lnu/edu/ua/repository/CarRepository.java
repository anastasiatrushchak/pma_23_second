package lnu.edu.ua.repository;

import lnu.edu.ua.model.entity.Car;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CarRepository extends JpaRepository<Car, Long> {

    Car findByCarID(Long carID);

    Car deleteCarByCarID(Long carID);
}
