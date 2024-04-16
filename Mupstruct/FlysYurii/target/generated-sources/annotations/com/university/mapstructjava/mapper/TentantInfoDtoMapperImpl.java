package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.TentantInfoDto;
import com.university.mapstructjava.entity.TenantInfo;
import javax.annotation.processing.Generated;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T16:28:44+0300",
    comments = "version: 1.5.5.Final, compiler: javac, environment: Java 21 (Oracle Corporation)"
)
public class TentantInfoDtoMapperImpl implements TentantInfoDtoMapper {

    @Override
    public TentantInfoDto toDto(TenantInfo tenantInfo) {
        if ( tenantInfo == null ) {
            return null;
        }

        TentantInfoDto tentantInfoDto = new TentantInfoDto();

        tentantInfoDto.setTentantName( tenantInfo.getTentantName() );
        tentantInfoDto.setTentantEmail( tenantInfo.getTentantEmail() );
        tentantInfoDto.setTentantPhone( tenantInfo.getTentantPhone() );
        tentantInfoDto.setTentantOccupation( tenantInfo.getTentantOccupation() );
        tentantInfoDto.setTentantAge( tenantInfo.getTentantAge() );
        tentantInfoDto.setTentantCreditScore( tenantInfo.getTentantCreditScore() );
        tentantInfoDto.setAgreementDate( tenantInfo.getAgreementDate() );
        tentantInfoDto.setAgreementStartDate( tenantInfo.getAgreementStartDate() );
        tentantInfoDto.setAgreementEndDate( tenantInfo.getAgreementEndDate() );
        tentantInfoDto.setAgreementType( tenantInfo.getAgreementType() );
        tentantInfoDto.setAdditionalTerms( tenantInfo.getAdditionalTerms() );

        return tentantInfoDto;
    }

    @Override
    public TenantInfo toEntity(TentantInfoDto tentantInfoDto) {
        if ( tentantInfoDto == null ) {
            return null;
        }

        TenantInfo tenantInfo = new TenantInfo();

        tenantInfo.setTentantName( tentantInfoDto.getTentantName() );
        tenantInfo.setTentantEmail( tentantInfoDto.getTentantEmail() );
        tenantInfo.setTentantPhone( tentantInfoDto.getTentantPhone() );
        tenantInfo.setTentantOccupation( tentantInfoDto.getTentantOccupation() );
        tenantInfo.setTentantAge( tentantInfoDto.getTentantAge() );
        tenantInfo.setTentantCreditScore( tentantInfoDto.getTentantCreditScore() );
        tenantInfo.setAgreementDate( tentantInfoDto.getAgreementDate() );
        tenantInfo.setAgreementStartDate( tentantInfoDto.getAgreementStartDate() );
        tenantInfo.setAgreementEndDate( tentantInfoDto.getAgreementEndDate() );
        tenantInfo.setAgreementType( tentantInfoDto.getAgreementType() );
        tenantInfo.setAdditionalTerms( tentantInfoDto.getAdditionalTerms() );

        return tenantInfo;
    }
}
