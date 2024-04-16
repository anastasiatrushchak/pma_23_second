package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.TenantInfoDto;
import com.university.mapstructjava.entity.TenantInfo;
import javax.annotation.processing.Generated;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T16:34:01+0300",
    comments = "version: 1.5.5.Final, compiler: javac, environment: Java 21 (Oracle Corporation)"
)
public class TenantInfoDtoMapperImpl implements TenantInfoDtoMapper {

    @Override
    public TenantInfoDto toDto(TenantInfo tenantInfo) {
        if ( tenantInfo == null ) {
            return null;
        }

        TenantInfoDto tenantInfoDto = new TenantInfoDto();

        tenantInfoDto.setAgreementDate( tenantInfo.getAgreementDate() );
        tenantInfoDto.setAgreementStartDate( tenantInfo.getAgreementStartDate() );
        tenantInfoDto.setAgreementEndDate( tenantInfo.getAgreementEndDate() );
        tenantInfoDto.setAgreementType( tenantInfo.getAgreementType() );
        tenantInfoDto.setAdditionalTerms( tenantInfo.getAdditionalTerms() );

        return tenantInfoDto;
    }

    @Override
    public TenantInfo toEntity(TenantInfoDto tenantInfoDto) {
        if ( tenantInfoDto == null ) {
            return null;
        }

        TenantInfo tenantInfo = new TenantInfo();

        tenantInfo.setAgreementDate( tenantInfoDto.getAgreementDate() );
        tenantInfo.setAgreementStartDate( tenantInfoDto.getAgreementStartDate() );
        tenantInfo.setAgreementEndDate( tenantInfoDto.getAgreementEndDate() );
        tenantInfo.setAgreementType( tenantInfoDto.getAgreementType() );
        tenantInfo.setAdditionalTerms( tenantInfoDto.getAdditionalTerms() );

        return tenantInfo;
    }
}
