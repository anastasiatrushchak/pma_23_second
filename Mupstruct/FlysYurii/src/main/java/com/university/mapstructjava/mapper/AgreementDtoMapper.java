package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.AgreementDto;
import com.university.mapstructjava.entity.Agreement;
import org.mapstruct.Mapper;

@Mapper
public interface AgreementDtoMapper {

        AgreementDto toDto(Agreement agreement);

        Agreement toEntity(AgreementDto agreementDto);
}
