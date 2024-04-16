package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.DeviceDetails;
import ua.edu.lnu.MapStruct.model.xml.DeviceDetailsXml;

@Mapper(componentModel = "spring")
public interface DeviceDetailsMapper {
    @Mapping(source = "deviceId", target = "deviceId")
    @Mapping(source = "agreementStartDate", target = "agreementStartDate")
    @Mapping(source = "agreementEndDate", target = "agreementEndDate")
    @Mapping(source = "deviceModel", target = "deviceModel")
    @Mapping(source = "deviceBrand", target = "deviceBrand")
    @Mapping(source = "deviceYear", target = "deviceYear")
    DeviceDetailsXml toXml(DeviceDetails deviceDetails);
}