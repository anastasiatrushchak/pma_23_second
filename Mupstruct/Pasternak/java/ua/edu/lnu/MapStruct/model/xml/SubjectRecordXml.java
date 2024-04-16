package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "SubjectRecord")
public class SubjectRecordXml {
    private String SubjectId;
    private SubjectDetailsXml SubjectDetails;
    private List<StudentDetailsXml> StudentDetails;

    @XmlElement(name = "SubjectId")
    public String getSubjectId() {
        return SubjectId;
    }

    public void setSubjectId(String SubjectId) {
        this.SubjectId = SubjectId;
    }

    @XmlElement(name = "SubjectDetails")
    public SubjectDetailsXml getSubjectDetails() {
        return SubjectDetails;
    }

    public void setSubjectDetails(SubjectDetailsXml SubjectDetails) {
        this.SubjectDetails = SubjectDetails;
    }

    @XmlElement(name = "StudentDetails")
    public List<StudentDetailsXml> getStudentDetails() {
        return StudentDetails;
    }

    public void setStudentDetails(List<StudentDetailsXml> StudentDetails) {
        this.StudentDetails = StudentDetails;
    }
}