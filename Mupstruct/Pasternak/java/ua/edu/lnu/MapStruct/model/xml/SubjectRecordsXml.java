package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "SubjectRecords")
public class SubjectRecordsXml {
    private List<SubjectRecordXml> SubjectRecords;

    @XmlElement(name = "SubjectRecord")
    public List<SubjectRecordXml> getSubjectRecords() {
        return SubjectRecords;
    }

    public void setSubjectRecords(List<SubjectRecordXml> SubjectRecords) {
        this.SubjectRecords = SubjectRecords;
    }
}