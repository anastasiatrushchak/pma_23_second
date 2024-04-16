package ua.edu.lnu.MapStruct.mapper;

import javax.annotation.processing.Generated;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.model.json.PhoneDetails;
import ua.edu.lnu.MapStruct.model.xml.PhoneDetailsXml;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-16T15:39:40+0300",
    comments = "version: 1.4.2.Final, compiler: javac, environment: Java 17.0.9 (GraalVM Community)"
)
@Component
public class PhoneDetailsMapperImpl implements PhoneDetailsMapper {

    @Override
    public PhoneDetailsXml toXml(PhoneDetails phoneDetails) {
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
}
