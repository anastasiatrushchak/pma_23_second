package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.DeviceDetails;
import ua.edu.lnu.MapStruct.model.json.DeviceRecord;
import ua.edu.lnu.MapStruct.model.json.CustomerInfo;
import ua.edu.lnu.MapStruct.model.xml.DeviceDetailsXml;
import ua.edu.lnu.MapStruct.model.xml.DeviceRecordXml;
import ua.edu.lnu.MapStruct.model.xml.CustomerInfoXml;

@Mapper(componentModel = "spring")
public interface DeviceRecordMapper {

    @Mapping(source = "agreementId", target = "agreementId")
    @Mapping(source = "deviceDetails", target = "deviceDetails")
    @Mapping(source = "customerInfos", target = "customerInfos")
    DeviceRecordXml toXml(DeviceRecord deviceRecord);

    DeviceDetailsXml map(DeviceDetails deviceDetails);

    CustomerInfoXml map(CustomerInfo customerInfo);
}
