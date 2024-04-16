package com.ua.edu.lnu.MapStruct.mapper;

import com.ua.edu.lnu.MapStruct.dto.CustomerInfoDto;
import com.ua.edu.lnu.MapStruct.entity.CustomerInfo;
import org.mapstruct.Mapper;
import org.mapstruct.Mapping;

@Mapper
public interface CustomerInfoDtoMapper {

    @Mapping(source = "agreementActiveAt", target="agreementActiveAt")
    @Mapping(source = "agreementCreatedOn", target="agreementCreatedOn")
    @Mapping(source = "agreementType", target="agreementType")
    @Mapping(source = "customerAddress", target="customerAddress")
    @Mapping(source = "customerContact", target="customerContact")
    @Mapping(source = "customerLicense", target="customerLicense")
    @Mapping(source = "customerName", target="customerName")
    @Mapping(source = "customerPhone", target="customerPhone")
    CustomerInfoDto toDto(CustomerInfo customerInfo);

    CustomerInfo toEntity(CustomerInfoDto customerInfoDto);
}
