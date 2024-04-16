package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.PropertyDetailsDto;
import com.university.mapstructjava.entity.PropertyDetails;
import org.mapstruct.Mapper;

@Mapper
public interface PropertyDetailsDtoMapper {
    public PropertyDetailsDto toDto(PropertyDetails propertyDetails);
    public PropertyDetails toEntity(PropertyDetailsDto propertyDetailsDto);
}
