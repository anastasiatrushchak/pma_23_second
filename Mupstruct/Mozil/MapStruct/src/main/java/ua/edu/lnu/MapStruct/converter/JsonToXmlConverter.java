package ua.edu.lnu.MapStruct.converter;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.mapper.PhoneDetailsMapper;
import ua.edu.lnu.MapStruct.mapper.PhoneRecordMapper;
import ua.edu.lnu.MapStruct.mapper.UserDetailsMapper;
import ua.edu.lnu.MapStruct.model.json.PhoneRecord;
import ua.edu.lnu.MapStruct.model.xml.PhoneRecordXml;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.Marshaller;
import ua.edu.lnu.MapStruct.model.xml.PhoneRecordsXml;

import java.io.File;
import java.util.List;
import java.util.stream.Collectors;

@Component
public class JsonToXmlConverter {

    private final PhoneDetailsMapper phoneDetailsMapper;
    private final PhoneRecordMapper phoneRecordMapper;
    private final UserDetailsMapper userDetailsMapper;

    @Autowired
    public JsonToXmlConverter(PhoneDetailsMapper phoneDetailsMapper, PhoneRecordMapper phoneRecordMapper, UserDetailsMapper userDetailsMapper) {
        this.phoneDetailsMapper = phoneDetailsMapper;
        this.phoneRecordMapper = phoneRecordMapper;
        this.userDetailsMapper = userDetailsMapper;
    }

    public void convertJsonToXml(List<PhoneRecord> phoneRecords, String outputFilePath) throws Exception {
        List<PhoneRecordXml> phoneRecordXmls = phoneRecords.stream()
                .map(record -> {
                    PhoneRecordXml phoneRecordXml = phoneRecordMapper.toXml(record);
                    phoneRecordXml.setPhoneDetails(phoneDetailsMapper.toXml(record.getPhoneDetails()));
                    phoneRecordXml.setUserDetails(record.getUserDetails().stream()
                            .map(userDetailsMapper::toXml)
                            .collect(Collectors.toList()));
                    return phoneRecordXml;
                })
                .collect(Collectors.toList());

        PhoneRecordsXml phoneRecordsXml = new PhoneRecordsXml();
        phoneRecordsXml.setPhoneRecords(phoneRecordXmls);

        JAXBContext context = JAXBContext.newInstance(PhoneRecordsXml.class);
        Marshaller marshaller = context.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);

        marshaller.marshal(phoneRecordsXml, new File(outputFilePath));
    }
}