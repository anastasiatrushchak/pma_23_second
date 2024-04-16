package com.university.mapstructjava.mapper.impl;

import com.university.mapstructjava.dto.PropertyDetailsDto;
import com.university.mapstructjava.entity.PropertyDetails;
import com.university.mapstructjava.mapper.PropertyDetailsDtoMapper;

public class PropertyDetailsDtoMapperImpl implements PropertyDetailsDtoMapper {

    @Override
    public PropertyDetailsDto toDto(PropertyDetails propertyDetails) {
        if ( propertyDetails == null ) {
            return null;
        }

        PropertyDetailsDto propertyDetailsDto = new PropertyDetailsDto();

        propertyDetailsDto.setObjectId( propertyDetails.getObjectId() );
        propertyDetailsDto.setAddress( propertyDetails.getAddress() );
        propertyDetailsDto.setCity( propertyDetails.getCity() );
        propertyDetailsDto.setState( propertyDetails.getState() );
        propertyDetailsDto.setZipCode( propertyDetails.getZipcode() );
        propertyDetailsDto.setPropertyType( propertyDetails.getType() );
        propertyDetailsDto.setBedrooms( propertyDetails.getBedrooms() );
        propertyDetailsDto.setSquareFootage( propertyDetails.getSquareFeet() );
        propertyDetailsDto.setBathrooms( propertyDetails.getBathrooms() );
        propertyDetailsDto.setRentPrice( propertyDetails.getRentPrice() );

        return propertyDetailsDto;
    }

    @Override
    public PropertyDetails toEntity(PropertyDetailsDto propertyDetailsDto) {
        return null;
    }
}
