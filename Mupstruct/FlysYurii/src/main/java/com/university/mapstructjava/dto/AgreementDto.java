package com.university.mapstructjava.dto;

import jakarta.xml.bind.annotation.XmlRootElement;

import java.util.ArrayList;

@XmlRootElement(name = "Agreement")
public class AgreementDto {
    private String id;
    private String agreementId;
    private ArrayList<PropertyDetailsDto> propertyDetails;
    private ArrayList<TenantInfoDto> tenantInfo;

    public AgreementDto() {
    }

    public AgreementDto(String id, String agreementId, ArrayList<PropertyDetailsDto> propertyDetails, ArrayList<TenantInfoDto> tenantInfo) {
        this.id = id;
        this.agreementId = agreementId;
        this.propertyDetails = propertyDetails;
        this.tenantInfo = tenantInfo;
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

    public ArrayList<PropertyDetailsDto> getPropertyDetails() {
        return propertyDetails;
    }

    public void setPropertyDetails(ArrayList<PropertyDetailsDto> propertyDetails) {
        this.propertyDetails = propertyDetails;
    }

    public ArrayList<TenantInfoDto> getTenantInfo() {
        return tenantInfo;
    }

    public void setTenantInfo(ArrayList<TenantInfoDto> tenantInfo) {
        this.tenantInfo = tenantInfo;
    }


}
