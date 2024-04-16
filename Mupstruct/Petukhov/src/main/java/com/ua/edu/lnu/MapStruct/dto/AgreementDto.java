package com.ua.edu.lnu.MapStruct.dto;

import jakarta.xml.bind.annotation.XmlRootElement;
import lombok.*;

import java.util.ArrayList;

@XmlRootElement(name = "Agreement")
public class AgreementDto {

    private String id;

    private String agreementId;

    private ArrayList<CarDetailsDto> carDetails;

    private ArrayList<CustomerInfoDto> customerInfo;

    public AgreementDto() {
    }

    public AgreementDto(String id, String agreementId, ArrayList<CarDetailsDto> carDetils, ArrayList<CustomerInfoDto> customerInfo) {
        this.id = id;
        this.agreementId = agreementId;
        this.carDetails = carDetails;
        this.customerInfo = customerInfo;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getAgreementId() {
        return agreementId;
    }

    public void setAgreementId(String agreementId) {
        this.agreementId = agreementId;
    }

    public ArrayList<CarDetailsDto> getCarDetails() {
        return carDetails;
    }

    public void setCarDetails(ArrayList<CarDetailsDto> carDetails) {
        this.carDetails = carDetails;
    }

    public ArrayList<CustomerInfoDto> getCustomerInfo() {
        return customerInfo;
    }

    public void setCustomerInfo(ArrayList<CustomerInfoDto> customerInfo) {
        this.customerInfo = customerInfo;
    }
}
