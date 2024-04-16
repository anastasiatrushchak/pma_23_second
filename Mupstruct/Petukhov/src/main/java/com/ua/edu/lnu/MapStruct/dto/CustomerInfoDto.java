package com.ua.edu.lnu.MapStruct.dto;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import lombok.*;

@XmlRootElement(name = "CustomerInfo")
public class CustomerInfoDto {

    private String agreementActiveAt;

    private String agreementCreatedOn;

    private String agreementType;

    private String customerAddress;

    private String customerContact;

    private String customerLicense;

    private String customerName;

    private String customerPhone;

    public CustomerInfoDto() {
    }

    public CustomerInfoDto(String agreementActiveAt, String agreementCreatedOn, String agreementType, String customerAddress, String customerContact, String customerLicense, String customerName, String customerPhone) {
        this.agreementActiveAt = agreementActiveAt;
        this.agreementCreatedOn = agreementCreatedOn;
        this.agreementType = agreementType;
        this.customerAddress = customerAddress;
        this.customerContact = customerContact;
        this.customerLicense = customerLicense;
        this.customerName = customerName;
        this.customerPhone = customerPhone;
    }

    public String getAgreementActiveAt() {
        return agreementActiveAt;
    }

    public void setAgreementActiveAt(String agreementActiveAt) {
        this.agreementActiveAt = agreementActiveAt;
    }

    public String getAgreementCreatedOn() {
        return agreementCreatedOn;
    }

    public void setAgreementCreatedOn(String agreementCreatedOn) {
        this.agreementCreatedOn = agreementCreatedOn;
    }

    public String getAgreementType() {
        return agreementType;
    }

    public void setAgreementType(String agreementType) {
        this.agreementType = agreementType;
    }

    public String getCustomerAddress() {
        return customerAddress;
    }

    public void setCustomerAddress(String customerAddress) {
        this.customerAddress = customerAddress;
    }

    public String getCustomerContact() {
        return customerContact;
    }

    public void setCustomerContact(String customerContact) {
        this.customerContact = customerContact;
    }

    public String getCustomerLicense() {
        return customerLicense;
    }

    public void setCustomerLicense(String customerLicense) {
        this.customerLicense = customerLicense;
    }

    public String getCustomerName() {
        return customerName;
    }

    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    public String getCustomerPhone() {
        return customerPhone;
    }

    public void setCustomerPhone(String customerPhone) {
        this.customerPhone = customerPhone;
    }
}
