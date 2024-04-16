package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.PropertyDetailsDto;
import com.university.mapstructjava.entity.PropertyDetails;
import javax.annotation.processing.Generated;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T15:40:21+0300",
    comments = "version: 1.5.5.Final, compiler: javac, environment: Java 21 (Oracle Corporation)"
)
public class PropertyDetailsDtoMapperImpl implements PropertyDetailsDtoMapper {

    @Override
    public PropertyDetailsDto toDto(PropertyDetails propertyDetails) {
        if ( propertyDetails == null ) {
            return null;
        }

        PropertyDetailsDto propertyDetailsDto = new PropertyDetailsDto();

        return propertyDetailsDto;
    }

    @Override
    public PropertyDetails toEntity(PropertyDetailsDto propertyDetailsDto) {
        if ( propertyDetailsDto == null ) {
            return null;
        }

        PropertyDetails propertyDetails = new PropertyDetails();

        return propertyDetails;
    }
}
