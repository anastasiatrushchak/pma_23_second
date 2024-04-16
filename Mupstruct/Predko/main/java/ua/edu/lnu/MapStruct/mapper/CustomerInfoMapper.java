package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.CustomerInfo;
import ua.edu.lnu.MapStruct.model.xml.CustomerInfoXml;

@Mapper(componentModel = "spring")
public interface CustomerInfoMapper {
    @Mapping(source="customerName", target="customerName")
    @Mapping(source="customerContact", target="customerContact")
    @Mapping(source="agreementActiveAt", target="agreementActiveAt")
    @Mapping(source="agreementCreatedOn", target="agreementCreatedOn")
    @Mapping(source="agreementType", target="agreementType")
    @Mapping(source="customerAddress", target="customerAddress")
    @Mapping(source="customerPhone", target="customerPhone")
    @Mapping(source="customerLicense", target="customerLicense")
    @Mapping(source="customerAge", target="customerAge")
    @Mapping(source="customerGender", target="customerGender")
    CustomerInfoXml toXml(CustomerInfo customerInfo);
}