//package com.ua.edu.lnu.MapStruct.mapper.impl;
//
//import com.ua.edu.lnu.MapStruct.dto.AgreementDto;
//import com.ua.edu.lnu.MapStruct.dto.CarDetailsDto;
//import com.ua.edu.lnu.MapStruct.dto.CustomerInfoDto;
//import com.ua.edu.lnu.MapStruct.entity.Agreement;
//import com.ua.edu.lnu.MapStruct.entity.CarDetails;
//import com.ua.edu.lnu.MapStruct.entity.CustomerInfo;
//import com.ua.edu.lnu.MapStruct.mapper.AgreementDtoMapper;
//import com.ua.edu.lnu.MapStruct.mapper.CarDetailsDtoMapper;
//import com.ua.edu.lnu.MapStruct.mapper.CustomerInfoDtoMapper;
//
//import java.util.ArrayList;
//
//public class AgreementDtoMapperImpl implements AgreementDtoMapper {
//
//
//    @Override
//    public AgreementDto toDto(Agreement agreement) {
//        if (agreement == null) {
//            return null;
//        }
//
//        AgreementDto agreementDto = new AgreementDto();
//
//        agreementDto.setId(agreement.getId());
//        agreementDto.setAgreementId(agreement.getAgreementId());
//
//        CarDetailsDtoMapper carDetailsDtoMapper = new CarDetailsDtoMapperImpl();
//        ArrayList<CarDetailsDto> carDetailsDtos = new ArrayList<>();
//
//        for (CarDetails carDetails : agreement.getCarDetails()) {
//            carDetailsDtos.add(carDetailsDtoMapper.toDto(carDetails));
//        }
//
//        agreementDto.setCarDetails(carDetailsDtos);
//
//        CustomerInfoDtoMapper customerInfoDtoMapper = new CustomerInfoDtoMapperImpl();
//        ArrayList<CustomerInfoDto> customerInfoDtos = new ArrayList<>();
//
//        for (CustomerInfo customerInfo : agreement.getCustomerInfo()) {
//            customerInfoDtos.add(customerInfoDtoMapper.toDto(customerInfo));
//        }
//
//        agreementDto.setCustomerInfo(customerInfoDtos);
//
//        return agreementDto;
//    }
//
//    @Override
//    public Agreement toEntity(AgreementDto agreementDto) {
//        return null;
//    }
//}
