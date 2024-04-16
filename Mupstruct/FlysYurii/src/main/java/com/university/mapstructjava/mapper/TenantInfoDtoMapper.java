package com.university.mapstructjava.mapper;

import com.university.mapstructjava.dto.TenantInfoDto;
import com.university.mapstructjava.entity.TenantInfo;
import org.mapstruct.Mapper;

@Mapper
public interface TenantInfoDtoMapper {
    public TenantInfoDto toDto(TenantInfo tenantInfo);
    public TenantInfo toEntity(TenantInfoDto tenantInfoDto);
}
