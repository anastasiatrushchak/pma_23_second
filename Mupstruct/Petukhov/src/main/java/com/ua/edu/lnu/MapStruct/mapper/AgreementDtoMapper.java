package com.ua.edu.lnu.MapStruct.mapper;

import com.ua.edu.lnu.MapStruct.dto.AgreementDto;
import com.ua.edu.lnu.MapStruct.entity.Agreement;
import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.factory.Mappers;

@Mapper(componentModel = "spring", uses = {
        CustomerInfoDtoMapper.class,
        CarDetailsDtoMapper.class,
})
public interface AgreementDtoMapper {

    AgreementDtoMapper INSTANCE = Mappers.getMapper(AgreementDtoMapper.class);

    /* TODO:
       add json property

     */

    @Mapping(source = "id", target="id")
    @Mapping(source = "agreementId", target="agreementId")
    @Mapping(source = "carDetails", target="carDetails")
    @Mapping(source = "agreementDto.customerInfo", target="customerInfo")
    AgreementDto toDto(Agreement agreement);

    Agreement toEntity(AgreementDto agreementDto);
}