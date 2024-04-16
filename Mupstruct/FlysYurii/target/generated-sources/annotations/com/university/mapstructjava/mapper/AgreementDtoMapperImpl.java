package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.AgreementDto;
import com.university.mapstructjava.entity.Agreement;
import javax.annotation.processing.Generated;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T15:40:21+0300",
    comments = "version: 1.5.5.Final, compiler: javac, environment: Java 21 (Oracle Corporation)"
)
public class AgreementDtoMapperImpl implements AgreementDtoMapper {

    @Override
    public AgreementDto toDto(Agreement agreement) {
        if ( agreement == null ) {
            return null;
        }

        AgreementDto agreementDto = new AgreementDto();

        return agreementDto;
    }

    @Override
    public Agreement toEntity(AgreementDto agreementDto) {
        if ( agreementDto == null ) {
            return null;
        }

        Agreement agreement = new Agreement();

        return agreement;
    }
}
