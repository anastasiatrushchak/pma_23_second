package ua.edu.lnu.MapStruct.mapper;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import ua.edu.lnu.MapStruct.model.json.SubjectDetails;
import ua.edu.lnu.MapStruct.model.xml.SubjectDetailsXml;

@Mapper(componentModel = "spring")
public interface SubjectDetailsMapper {
    @Mapping(source = "subjectId", target = "subjectId")
    @Mapping(source = "teacher", target = "teacher")
    @Mapping(source = "countHours", target = "countHours")
    @Mapping(source = "ECTS", target = "ECTS")
    @Mapping(source = "semester", target = "semester")
    @Mapping(source = "isExam", target = "isExam")
    SubjectDetailsXml toXml(SubjectDetails SubjectDetails);
}