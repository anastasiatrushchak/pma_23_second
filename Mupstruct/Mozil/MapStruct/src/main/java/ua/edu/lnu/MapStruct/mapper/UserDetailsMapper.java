package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.UserDetails;
import ua.edu.lnu.MapStruct.model.xml.UserDetailsXml;

@Mapper(componentModel = "spring")
public interface UserDetailsMapper {
    @Mapping(source="userName", target="userName")
    @Mapping(source="userContact", target="userContact")
    @Mapping(source="userActiveAt", target="userActiveAt")
    @Mapping(source="userCreatedOn", target="userCreatedOn")
    @Mapping(source="userType", target="userType")
    @Mapping(source="userAddress", target="userAddress")
    @Mapping(source="userPhone", target="userPhone")
    @Mapping(source="userLicense", target="userLicense")
    UserDetailsXml toXml(UserDetails userDetails);
}