package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class CustomerInfo {
    @JsonProperty("customerName")
    private String customerName;

    @JsonProperty("customerContact")
    private String customerContact;

    @JsonProperty("agreementActiveAt")
    private String agreementActiveAt;

    @JsonProperty("agreementCreatedOn")
    private String agreementCreatedOn;

    @JsonProperty("agreementType")
    private String agreementType;

    @JsonProperty("customerAddress")
    private String customerAddress;

    @JsonProperty("customerPhone")
    private String customerPhone;

    @JsonProperty("customerLicense")
    private String customerLicense;

    @JsonProperty("customerAge")
    private String customerAge;

    @JsonProperty("customerGender")
    private String customerGender;

    public String getCustomerName() {
        return customerName;
    }

    public String getCustomerContact() {
        return customerContact;
    }

    public String getAgreementActiveAt() {
        return agreementActiveAt;
    }

    public String getAgreementCreatedOn() {
        return agreementCreatedOn;
    }

    public String getAgreementType() {
        return agreementType;
    }

    public String getCustomerAddress() {
        return customerAddress;
    }

    public String getCustomerPhone() {
        return customerPhone;
    }

    public String getCustomerLicense() {
        return customerLicense;
    }

    public String getCustomerAge() {
        return customerAge;
    }

    public String getCustomerGender() {
        return customerGender;
    }

}