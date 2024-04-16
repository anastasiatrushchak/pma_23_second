package ua.edu.lnu.MapStruct.mapper;

import java.util.ArrayList;
import java.util.List;
import javax.annotation.processing.Generated;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.model.json.PhoneDetails;
import ua.edu.lnu.MapStruct.model.json.PhoneRecord;
import ua.edu.lnu.MapStruct.model.json.UserDetails;
import ua.edu.lnu.MapStruct.model.xml.PhoneDetailsXml;
import ua.edu.lnu.MapStruct.model.xml.PhoneRecordXml;
import ua.edu.lnu.MapStruct.model.xml.UserDetailsXml;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T15:39:41+0300",
    comments = "version: 1.4.2.Final, compiler: javac, environment: Java 17.0.9 (GraalVM Community)"
)
@Component
public class PhoneRecordMapperImpl implements PhoneRecordMapper {

    @Override
    public PhoneRecordXml toXml(PhoneRecord phoneRecord) {
        if ( phoneRecord == null ) {
            return null;
        }

        PhoneRecordXml phoneRecordXml = new PhoneRecordXml();

        phoneRecordXml.setPhoneId( phoneRecord.getPhoneId() );
        phoneRecordXml.setPhoneDetails( map( phoneRecord.getPhoneDetails() ) );
        phoneRecordXml.setUserDetails( userDetailsListToUserDetailsXmlList( phoneRecord.getUserDetails() ) );

        return phoneRecordXml;
    }

    @Override
    public PhoneDetailsXml map(PhoneDetails phoneDetails) {
        if ( phoneDetails == null ) {
            return null;
        }

        PhoneDetailsXml phoneDetailsXml = new PhoneDetailsXml();

        phoneDetailsXml.setModelId( phoneDetails.getModelId() );
        phoneDetailsXml.setPhoneStartDate( phoneDetails.getPhoneStartDate() );
        phoneDetailsXml.setPhoneEndDate( phoneDetails.getPhoneEndDate() );
        phoneDetailsXml.setPhoneModel( phoneDetails.getPhoneModel() );
        phoneDetailsXml.setPhoneBrand( phoneDetails.getPhoneBrand() );
        phoneDetailsXml.setPhoneYear( phoneDetails.getPhoneYear() );

        return phoneDetailsXml;
    }

    @Override
    public UserDetailsXml map(UserDetails userDetails) {
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

    protected List<UserDetailsXml> userDetailsListToUserDetailsXmlList(List<UserDetails> list) {
        if ( list == null ) {
            return null;
        }

        List<UserDetailsXml> list1 = new ArrayList<UserDetailsXml>( list.size() );
        for ( UserDetails userDetails : list ) {
            list1.add( map( userDetails ) );
        }

        return list1;
    }
}
