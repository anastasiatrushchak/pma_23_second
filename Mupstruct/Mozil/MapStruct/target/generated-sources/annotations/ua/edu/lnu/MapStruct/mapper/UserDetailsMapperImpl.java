package ua.edu.lnu.MapStruct.mapper;

import javax.annotation.processing.Generated;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.model.json.UserDetails;
import ua.edu.lnu.MapStruct.model.xml.UserDetailsXml;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T15:39:41+0300",
    comments = "version: 1.4.2.Final, compiler: javac, environment: Java 17.0.9 (GraalVM Community)"
)
@Component
public class UserDetailsMapperImpl implements UserDetailsMapper {

    @Override
    public UserDetailsXml toXml(UserDetails userDetails) {
        if ( userDetails == null ) {
            return null;
        }

        UserDetailsXml userDetailsXml = new UserDetailsXml();

        userDetailsXml.setUserName( userDetails.getUserName() );
        userDetailsXml.setUserContact( userDetails.getUserContact() );
        userDetailsXml.setUserActiveAt( userDetails.getUserActiveAt() );
        userDetailsXml.setUserCreatedOn( userDetails.getUserCreatedOn() );
        userDetailsXml.setUserType( userDetails.getUserType() );
        userDetailsXml.setUserAddress( userDetails.getUserAddress() );
        userDetailsXml.setUserPhone( userDetails.getUserPhone() );
        userDetailsXml.setUserLicense( userDetails.getUserLicense() );

        return userDetailsXml;
    }
}
