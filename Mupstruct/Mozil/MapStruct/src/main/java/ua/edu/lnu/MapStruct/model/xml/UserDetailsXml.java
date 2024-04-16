package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "userDetails")
public class UserDetailsXml {
    private String userName;
    private String userContact;
    private String userActiveAt;
    private String userCreatedOn;
    private String userType;
    private String userAddress;
    private String userPhone;
    private String userLicense;

    @XmlElement(name = "userName")
    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    @XmlElement(name = "userContact")
    public String getUserContact() {
        return userContact;
    }

    public void setUserContact(String userContact) {
        this.userContact = userContact;
    }

    @XmlElement(name = "userActiveAt")
    public String getUserActiveAt() {
        return userActiveAt;
    }

    public void setUserActiveAt(String userActiveAt) {
        this.userActiveAt = userActiveAt;
    }

    @XmlElement(name = "userCreatedOn")
    public String getUserCreatedOn() {
        return userCreatedOn;
    }

    public void setUserCreatedOn(String userCreatedOn) {
        this.userCreatedOn = userCreatedOn;
    }

    @XmlElement(name = "userType")
    public String getUserType() {
        return userType;
    }

    public void setUserType(String userType) {
        this.userType = userType;
    }

    @XmlElement(name = "userAddress")
    public String getUserAddress() {
        return userAddress;
    }

    public void setUserAddress(String userAddress) {
        this.userAddress = userAddress;
    }

    @XmlElement(name = "userPhone")
    public String getUserPhone() {
        return userPhone;
    }

    public void setUserPhone(String userPhone) {
        this.userPhone = userPhone;
    }

    @XmlElement(name = "userLicense")
    public String getUserLicense() {
        return userLicense;
    }

    public void setUserLicense(String userLicense) {
        this.userLicense = userLicense;
    }
}