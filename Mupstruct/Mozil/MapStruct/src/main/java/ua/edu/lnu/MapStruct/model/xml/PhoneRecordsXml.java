package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "PhoneRecords")
public class PhoneRecordsXml {
    private List<PhoneRecordXml> phoneRecords;

    @XmlElement(name = "PhoneRecord")
    public List<PhoneRecordXml> getPhoneRecords() {
        return phoneRecords;
    }

    public void setPhoneRecords(List<PhoneRecordXml> phoneRecords) {
        this.phoneRecords = phoneRecords;
    }
}