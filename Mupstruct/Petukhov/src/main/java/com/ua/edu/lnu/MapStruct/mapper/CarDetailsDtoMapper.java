package com.ua.edu.lnu.MapStruct.mapper;

import com.ua.edu.lnu.MapStruct.dto.CarDetailsDto;
import com.ua.edu.lnu.MapStruct.entity.CarDetails;
import org.mapstruct.Mapper;
import org.mapstruct.Mapping;

@Mapper
public interface CarDetailsDtoMapper {

    @Mapping(source = "carId", target="carId")
    @Mapping(source = "carMake", target="carMake")
    @Mapping(source = "carModel", target="carModel")
    @Mapping(source = "carYear", target="carYear")
    @Mapping(source = "agreementEndDate", target="agreementEndDate")
    @Mapping(source = "agreementStartDate", target="agreementStartDate")
    CarDetailsDto toDto(CarDetails carDetails);

    CarDetails toEntity(CarDetailsDto carDetailsDto);
}
