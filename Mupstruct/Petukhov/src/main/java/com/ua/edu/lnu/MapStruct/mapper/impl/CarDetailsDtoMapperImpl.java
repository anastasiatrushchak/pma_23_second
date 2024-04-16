//package com.ua.edu.lnu.MapStruct.mapper.impl;
//
//import com.ua.edu.lnu.MapStruct.dto.CarDetailsDto;
//import com.ua.edu.lnu.MapStruct.entity.CarDetails;
//import com.ua.edu.lnu.MapStruct.mapper.CarDetailsDtoMapper;
//
//public class CarDetailsDtoMapperImpl implements CarDetailsDtoMapper {
//
//
//    @Override
//    public CarDetailsDto toDto(CarDetails carDetails) {
//        if (carDetails == null) {
//            return null;
//        }
//
//        CarDetailsDto carDetailsDto = new CarDetailsDto();
//
//        carDetailsDto.setCarId(carDetails.getCarId());
//        carDetailsDto.setCarMake(carDetails.getCarMake());
//        carDetailsDto.setCarModel(carDetails.getCarModel());
//        carDetailsDto.setCarYear(carDetails.getCarYear());
//        carDetailsDto.setAgreementEndDate(carDetails.getAgreementEndDate());
//        carDetailsDto.setAgreementStartDate(carDetails.getAgreementStartDate());
//
//        return carDetailsDto;
//    }
//
//    @Override
//    public CarDetails toEntity(CarDetailsDto carDetailsDto) {
//        return null;
//    }
//}
