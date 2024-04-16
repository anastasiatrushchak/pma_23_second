package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "PhoneRecord")
public class PhoneRecordXml {
    private String phoneId;
    private PhoneDetailsXml phoneDetails;
    private List<UserDetailsXml> userDetails;

    @XmlElement(name = "phoneId")
    public String getPhoneId() {
        return phoneId;
    }

    public void setPhoneId(String phoneId) {
        this.phoneId = phoneId;
    }

    @XmlElement(name = "phoneDetails")
    public PhoneDetailsXml getPhoneDetails() {
        return phoneDetails;
    }

    public void setPhoneDetails(PhoneDetailsXml phoneDetails) {
        this.phoneDetails = phoneDetails;
    }

    @XmlElement(name = "userDetails")
    public List<UserDetailsXml> getUserDetails() {
        return userDetails;
    }

    public void setUserDetails(List<UserDetailsXml> userDetails) {
        this.userDetails = userDetails;
    }
}