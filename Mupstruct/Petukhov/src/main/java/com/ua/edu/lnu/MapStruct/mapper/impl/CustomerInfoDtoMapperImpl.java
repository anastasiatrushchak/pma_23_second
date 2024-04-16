//package com.ua.edu.lnu.MapStruct.mapper.impl;
//
//import com.ua.edu.lnu.MapStruct.dto.CustomerInfoDto;
//import com.ua.edu.lnu.MapStruct.entity.CustomerInfo;
//import com.ua.edu.lnu.MapStruct.mapper.CustomerInfoDtoMapper;
//
//public class CustomerInfoDtoMapperImpl implements CustomerInfoDtoMapper {
//
//
//    @Override
//    public CustomerInfoDto toDto(CustomerInfo customerInfo) {
//        if (customerInfo == null) {
//            return null;
//        }
//
//        CustomerInfoDto customerInfoDto = new CustomerInfoDto();
//
//        customerInfoDto.setAgreementActiveAt(customerInfo.getAgreementActiveAt());
//        customerInfoDto.setAgreementCreatedOn(customerInfo.getAgreementCreatedOn());
//        customerInfoDto.setAgreementType(customerInfo.getAgreementType());
//        customerInfoDto.setCustomerAddress(customerInfo.getCustomerAddress());
//        customerInfoDto.setCustomerContact(customerInfo.getCustomerContact());
//        customerInfoDto.setCustomerLicense(customerInfo.getCustomerLicense());
//        customerInfoDto.setCustomerName(customerInfo.getCustomerName());
//        customerInfoDto.setCustomerPhone(customerInfo.getCustomerPhone());
//
//        return customerInfoDto;
//    }
//
//    @Override
//    public CustomerInfo toEntity(CustomerInfoDto customerInfoDto) {
//        return null;
//    }
//}
