package ua.edu.lnu.MapStruct.converter;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.mapper.SubjectDetailsMapper;
import ua.edu.lnu.MapStruct.mapper.SubjectRecordMapper;
import ua.edu.lnu.MapStruct.mapper.StudentDetailsMapper;
import ua.edu.lnu.MapStruct.model.json.SubjectRecord;
import ua.edu.lnu.MapStruct.model.xml.SubjectRecordXml;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.Marshaller;
import ua.edu.lnu.MapStruct.model.xml.SubjectRecordsXml;

import java.io.File;
import java.util.List;
import java.util.stream.Collectors;

@Component
public class JsonToXmlConverter {

    private final SubjectDetailsMapper SubjectDetailsMapper;
    private final SubjectRecordMapper SubjectRecordMapper;
    private final StudentDetailsMapper StudentDetailsMapper;

    @Autowired
    public JsonToXmlConverter(SubjectDetailsMapper SubjectDetailsMapper, SubjectRecordMapper SubjectRecordMapper, StudentDetailsMapper StudentDetailsMapper) {
        this.SubjectDetailsMapper = SubjectDetailsMapper;
        this.SubjectRecordMapper = SubjectRecordMapper;
        this.StudentDetailsMapper = StudentDetailsMapper;
    }

    public void convertJsonToXml(List<SubjectRecord> SubjectRecords, String outputFilePath) throws Exception {
        List<SubjectRecordXml> SubjectRecordXmls = SubjectRecords.stream()
                .map(record -> {
                    SubjectRecordXml SubjectRecordXml = SubjectRecordMapper.toXml(record);
                    SubjectRecordXml.setSubjectDetails(SubjectDetailsMapper.toXml(record.getSubjectDetails()));
                    SubjectRecordXml.setStudentDetails(record.getStudentDetails().stream()
                            .map(StudentDetailsMapper::toXml)
                            .collect(Collectors.toList()));
                    return SubjectRecordXml;
                })
                .collect(Collectors.toList());

        SubjectRecordsXml SubjectRecordsXml = new SubjectRecordsXml();
        SubjectRecordsXml.setSubjectRecords(SubjectRecordXmls);

        JAXBContext context = JAXBContext.newInstance(SubjectRecordsXml.class);
        Marshaller marshaller = context.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);

        marshaller.marshal(SubjectRecordsXml, new File(outputFilePath));
    }
}