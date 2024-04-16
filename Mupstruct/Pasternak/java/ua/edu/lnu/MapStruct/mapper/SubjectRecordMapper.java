package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.SubjectDetails;
import ua.edu.lnu.MapStruct.model.json.SubjectRecord;
import ua.edu.lnu.MapStruct.model.json.StudentDetails;
import ua.edu.lnu.MapStruct.model.xml.SubjectDetailsXml;
import ua.edu.lnu.MapStruct.model.xml.SubjectRecordXml;
import ua.edu.lnu.MapStruct.model.xml.StudentDetailsXml;

@Mapper(componentModel = "spring")
public interface SubjectRecordMapper {

    @Mapping(source = "SubjectId", target = "SubjectId")
    @Mapping(source = "SubjectDetails", target = "SubjectDetails")
    @Mapping(source = "StudentDetails", target = "StudentDetails")
    SubjectRecordXml toXml(SubjectRecord SubjectRecord);

    SubjectDetailsXml map(SubjectDetails SubjectDetails);

    StudentDetailsXml map(StudentDetails StudentDetails);
}