package com.university.mapstructjava.dto;

import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "PropertyDetails")
public class PropertyDetailsDto {

    private String objectId;
    private String address;
    private String city;
    private String state;
    private String zipCode;
    private String propertyType;
    private Long bedrooms;
    private Long bathrooms;
    private Long squareFootage;
    private Long rentPrice;

    public PropertyDetailsDto() {
    }

    public PropertyDetailsDto(String objectId, String address, String city, String state, String zipCode, String propertyType, Long bedrooms, Long bathrooms, Long squareFootage, Long rentPrice) {
        this.objectId = objectId;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
        this.propertyType = propertyType;
        this.bedrooms = bedrooms;
        this.bathrooms = bathrooms;
        this.squareFootage = squareFootage;
        this.rentPrice = rentPrice;
    }

    public String getObjectId() {
        return objectId;
    }

    public void setObjectId(String objectId) {
        this.objectId = objectId;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }

    public String getZipCode() {
        return zipCode;
    }

    public void setZipCode(String zipCode) {
        this.zipCode = zipCode;
    }

    public String getPropertyType() {
        return propertyType;
    }

    public void setPropertyType(String propertyType) {
        this.propertyType = propertyType;
    }

    public Long getBedrooms() {
        return bedrooms;
    }

    public void setBedrooms(Long bedrooms) {
        this.bedrooms = bedrooms;
    }

    public Long getBathrooms() {
        return bathrooms;
    }

    public void setBathrooms(Long bathrooms) {
        this.bathrooms = bathrooms;
    }

    public Long getSquareFootage() {
        return squareFootage;
    }

    public void setSquareFootage(Long squareFootage) {
        this.squareFootage = squareFootage;
    }

    public Long getRentPrice() {
        return rentPrice;
    }

    public void setRentPrice(Long rentPrice) {
        this.rentPrice = rentPrice;
    }
}
