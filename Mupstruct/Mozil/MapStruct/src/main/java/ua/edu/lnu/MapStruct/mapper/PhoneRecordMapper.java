package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.PhoneDetails;
import ua.edu.lnu.MapStruct.model.json.PhoneRecord;
import ua.edu.lnu.MapStruct.model.json.UserDetails;
import ua.edu.lnu.MapStruct.model.xml.PhoneDetailsXml;
import ua.edu.lnu.MapStruct.model.xml.PhoneRecordXml;
import ua.edu.lnu.MapStruct.model.xml.UserDetailsXml;

@Mapper(componentModel = "spring")
public interface PhoneRecordMapper {

    @Mapping(source = "phoneId", target = "phoneId")
    @Mapping(source = "phoneDetails", target = "phoneDetails")
    @Mapping(source = "userDetails", target = "userDetails")
    PhoneRecordXml toXml(PhoneRecord phoneRecord);

    PhoneDetailsXml map(PhoneDetails phoneDetails);

    UserDetailsXml map(UserDetails userDetails);
}