package com.university.mapstructjava.mapper.impl;

import com.university.mapstructjava.dto.AgreementDto;
import com.university.mapstructjava.dto.PropertyDetailsDto;
import com.university.mapstructjava.dto.TenantInfoDto;
import com.university.mapstructjava.entity.Agreement;
import com.university.mapstructjava.entity.PropertyDetails;
import com.university.mapstructjava.entity.TenantInfo;
import com.university.mapstructjava.mapper.AgreementDtoMapper;
import com.university.mapstructjava.mapper.PropertyDetailsDtoMapper;
import com.university.mapstructjava.mapper.TenantInfoDtoMapper;

import java.util.ArrayList;

public class AgreementDtoMapperImpl implements AgreementDtoMapper {

    @Override
    public AgreementDto toDto(Agreement agreement) {
        if (agreement == null) {
            return null;
        }

        AgreementDto agreementDto = new AgreementDto();

        agreementDto.setId(agreement.getId());
        agreementDto.setAgreementId(agreement.getAgreementId());

        PropertyDetailsDtoMapper propertyDetailsDtoMapper = new PropertyDetailsDtoMapperImpl();
        ArrayList<PropertyDetailsDto> propertyDetailsDtos = new ArrayList<>();

        for (PropertyDetails propertyDetails : agreement.getPropertyDetails()) {
            propertyDetailsDtos.add(propertyDetailsDtoMapper.toDto(propertyDetails));
        }

        agreementDto.setPropertyDetails(propertyDetailsDtos);

        TenantInfoDtoMapper tenantInfoDtoMapper = new TenantInfoDtoMapperImpl();
        ArrayList<TenantInfoDto> tenantInfoDtos = new ArrayList<>();

        if (agreement.getTentantInfo() != null) {
            for (TenantInfo tenantInfo : agreement.getTentantInfo()) {
                tenantInfoDtos.add(tenantInfoDtoMapper.toDto(tenantInfo));
            }
        }

        agreementDto.setTenantInfo(tenantInfoDtos);

        return agreementDto;
    }


    @Override
    public Agreement toEntity(AgreementDto agreementDto) {
        if ( agreementDto == null ) {
            return null;
        }

        Agreement agreement = new Agreement();

        agreement.setId( agreementDto.getId() );
        agreement.setAgreementId( agreementDto.getAgreementId() );

        PropertyDetailsDtoMapper propertyDetailsDtoMapper = new PropertyDetailsDtoMapperImpl();
        ArrayList<PropertyDetails> propertyDetails = new ArrayList<>();

        for ( PropertyDetailsDto propertyDetailsDto : agreementDto.getPropertyDetails() ) {
            propertyDetails.add( propertyDetailsDtoMapper.toEntity( propertyDetailsDto ) );
        }

        agreement.setPropertyDetails( propertyDetails );

        TenantInfoDtoMapper tenantInfoDtoMapper = new TenantInfoDtoMapperImpl();
        ArrayList<TenantInfo> tenantInfos = new ArrayList<>();

        for (TenantInfoDto tenantInfoDto : agreementDto.getTenantInfo()) {
            tenantInfos.add(tenantInfoDtoMapper.toEntity(tenantInfoDto));
        }

        agreement.setTentantInfo(tenantInfos);

        return agreement;
    }
}
