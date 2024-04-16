package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "customerInfo")
public class CustomerInfoXml {
    private String customerName;
    private String customerContact;
    private String agreementActiveAt;
    private String agreementCreatedOn;
    private String agreementType;
    private String customerAddress;
    private String customerPhone;
    private String customerLicense;

    private String customerAge;

    private String customerGender;

    public void setAgreementType(String agreementType) {
        this.agreementType = agreementType;
    }

    public void setCustomerAddress(String customerAddress) {
        this.customerAddress = customerAddress;
    }

    public void setCustomerPhone(String customerPhone) {
        this.customerPhone = customerPhone;
    }

    public void setCustomerLicense(String customerLicense) {
        this.customerLicense = customerLicense;
    }

    public void setCustomerAge(String customerAge) {
        this.customerAge = customerAge;
    }

    public void setCustomerGender(String customerGender) {
        this.customerGender = customerGender;
    }

    public String getCustomerGender() {
        return customerGender;
    }

    @XmlElement(name = "customerAge")
    public String getCustomerAge() {
        return customerAge;
    }


    @XmlElement(name = "customerName")
    public String getCustomerName() {
        return customerName;
    }

    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    @XmlElement(name = "customerContact")
    public String getCustomerContact() {
        return customerContact;
    }

    public void setCustomerContact(String customerContact) {
        this.customerContact = customerContact;
    }

    @XmlElement(name = "agreementActiveAt")
    public String getAgreementActiveAt() {
        return agreementActiveAt;
    }

    public void setAgreementActiveAt(String agreementActiveAt) {
        this.agreementActiveAt = agreementActiveAt;
    }

    @XmlElement(name = "agreementCreatedOn")
    public String getAgreementCreatedOn() {
        return agreementCreatedOn;
    }

    public void setAgreementCreatedOn(String agreementCreatedOn) {
        this.agreementCreatedOn = agreementCreatedOn;
    }

    @XmlElement(name = "agreementType")
    public String getAgreementType() {
        return agreementType;
    }

    public void setUserType(String agreementType) {
        this.agreementType = agreementType;
    }

    @XmlElement(name = "customerAddress")
    public String getCustomerAddress() {
        return customerAddress;
    }

    public void setUserAddress(String customerAddress) {
        this.customerAddress = customerAddress;
    }

    @XmlElement(name = "customerPhone")
    public String getCustomerPhone() {
        return customerPhone;
    }

    public void setUserPhone(String customerPhone) {
        this.customerPhone = customerPhone;
    }

    @XmlElement(name = "customerLicense")
    public String getCustomerLicense() {
        return customerLicense;
    }

    public void setUserLicense(String customerLicense) {
        this.customerLicense = customerLicense;
    }
}