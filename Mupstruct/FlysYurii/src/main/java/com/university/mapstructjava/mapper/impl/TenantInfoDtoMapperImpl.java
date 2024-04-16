package com.university.mapstructjava.mapper.impl;

import com.university.mapstructjava.dto.TenantInfoDto;
import com.university.mapstructjava.entity.TenantInfo;
import com.university.mapstructjava.mapper.TenantInfoDtoMapper;

public class TenantInfoDtoMapperImpl implements TenantInfoDtoMapper {

    @Override
    public TenantInfoDto toDto(TenantInfo tenantInfo) {
        if ( tenantInfo == null ) {
            return null;
        }

        TenantInfoDto tenantInfoDto = new TenantInfoDto();

        tenantInfoDto.setTenantName( tenantInfo.getTenantName() );
        tenantInfoDto.setTenantEmail( tenantInfo.getTenantEmail() );
        tenantInfoDto.setTenantPhone( tenantInfo.getTenantPhone() );
        tenantInfoDto.setTenantOccupation( tenantInfo.getTenantOccupation() );
        tenantInfoDto.setTenantAge( tenantInfo.getTenantAge() );
        tenantInfoDto.setTenantCreditScore( tenantInfo.getTenantCreditScore() );
        tenantInfoDto.setAgreementDate( tenantInfo.getAgreementDate() );
        tenantInfoDto.setAgreementType( tenantInfo.getAgreementType() );
        tenantInfoDto.setAgreementStartDate( tenantInfo.getAgreementStartDate() );
        tenantInfoDto.setAgreementEndDate( tenantInfo.getAgreementEndDate() );
        tenantInfoDto.setAdditionalTerms( tenantInfo.getAdditionalTerms() );


        return tenantInfoDto;
    }

    @Override
    public TenantInfo toEntity(TenantInfoDto tenantInfoDto) {
        return null;
    }
}
