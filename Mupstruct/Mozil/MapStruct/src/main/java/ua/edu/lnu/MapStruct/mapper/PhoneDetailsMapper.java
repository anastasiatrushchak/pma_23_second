package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.PhoneDetails;
import ua.edu.lnu.MapStruct.model.xml.PhoneDetailsXml;

@Mapper(componentModel = "spring")
public interface PhoneDetailsMapper {
    @Mapping(source = "modelId", target = "modelId")
    @Mapping(source = "phoneStartDate", target = "phoneStartDate")
    @Mapping(source = "phoneEndDate", target = "phoneEndDate")
    @Mapping(source = "phoneModel", target = "phoneModel")
    @Mapping(source = "phoneBrand", target = "phoneBrand")
    @Mapping(source = "phoneYear", target = "phoneYear")
    PhoneDetailsXml toXml(PhoneDetails phoneDetails);
}