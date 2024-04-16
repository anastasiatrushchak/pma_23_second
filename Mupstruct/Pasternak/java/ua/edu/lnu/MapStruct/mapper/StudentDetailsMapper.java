package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.StudentDetails;
import ua.edu.lnu.MapStruct.model.xml.StudentDetailsXml;

@Mapper(componentModel = "spring")
public interface StudentDetailsMapper {
    @Mapping(source="firstName", target="firstName")
    @Mapping(source="lastName", target="lastName")
    @Mapping(source="email", target="email")
    @Mapping(source="phone", target="phone")
    @Mapping(source="address", target="address")
    @Mapping(source="city", target="city")
    @Mapping(source="age", target="age")
    @Mapping(source="bithday", target="bithday")
    StudentDetailsXml toXml(StudentDetails StudentDetails);
}