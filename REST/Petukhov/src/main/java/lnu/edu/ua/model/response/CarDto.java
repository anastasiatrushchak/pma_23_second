package lnu.edu.ua.model.response;

import lnu.edu.ua.model.entity.Car;

public record CarDto (
        Long car_id,
        String number,
        String brand,
        String type,
        String color,
        Integer seats,
        String manufacturer
){
    public CarDto(Car entity) {
        this(
                entity.getCarID(),
                entity.getCarNumber(),
                entity.getCarBrand(),
                entity.getCarType(),
                entity.getCarColor(),
                entity.getCarSeats(),
                entity.getCarManufacturer()
        );
    }
}
