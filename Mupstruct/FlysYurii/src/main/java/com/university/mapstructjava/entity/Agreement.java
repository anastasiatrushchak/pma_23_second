package com.university.mapstructjava.entity;


import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.mongodb.core.mapping.Field;
import org.springframework.data.mongodb.core.mapping.MongoId;

import java.util.ArrayList;


@Document(collection = "mapstruct")
public class Agreement {
    @MongoId
    private String id;
    private String agreementId;
    @Field("propertyDetails")
    private ArrayList<PropertyDetails> propertyDetails;
    @Field("tenantInfo")
    private ArrayList<TenantInfo> tenantInfo;

    public Agreement() {
    }

    public Agreement(String id, String agreementId, ArrayList<PropertyDetails> propertyDetails, ArrayList<TenantInfo> tenantInfo) {
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

    public ArrayList<PropertyDetails> getPropertyDetails() {
        return propertyDetails;
    }

    public void setPropertyDetails(ArrayList<PropertyDetails> propertyDetails) {
        this.propertyDetails = propertyDetails;
    }

    public ArrayList<TenantInfo> getTentantInfo() {
        return tenantInfo;
    }

    public void setTentantInfo(ArrayList<TenantInfo> tenantInfo) {
        this.tenantInfo = tenantInfo;
    }

    @Override
    public String toString() {
        return "Agreement{" +
                "id='" + id + '\'' +
                ", agreementId='" + agreementId + '\'' +
                ", propertyDetails=" + propertyDetails +
                ", tenantInfo=" + tenantInfo +
                '}';
    }
}
