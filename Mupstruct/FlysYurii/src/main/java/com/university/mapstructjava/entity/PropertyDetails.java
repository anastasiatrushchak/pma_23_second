package com.university.mapstructjava.entity;


import org.springframework.data.mongodb.core.mapping.Document;


@Document(collection = "mapstruct")
public class PropertyDetails {

    private String objectId;
    private String address;
    private String city;
    private String state;
    private String zipcode;
    private String type;
    private Long bedrooms;
    private Long bathrooms;
    private Long squareFeet;
    private Long rentPrice;

    public PropertyDetails(String objectId, String address, String city, String state, String zipcode, String type, Long bedrooms, Long bathrooms, Long squareFeet, Long rentPrice) {
        this.objectId = objectId;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zipcode = zipcode;
        this.type = type;
        this.bedrooms = bedrooms;
        this.bathrooms = bathrooms;
        this.squareFeet = squareFeet;
        this.rentPrice = rentPrice;
    }

    public PropertyDetails() {
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

    public String getZipcode() {
        return zipcode;
    }

    public void setZipcode(String zipcode) {
        this.zipcode = zipcode;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
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

    public Long getSquareFeet() {
        return squareFeet;
    }

    public void setSquareFeet(Long squareFeet) {
        this.squareFeet = squareFeet;
    }

    public Long getRentPrice() {
        return rentPrice;
    }

    public void setRentPrice(Long rentPrice) {
        this.rentPrice = rentPrice;
    }

    @Override
    public String toString() {
        return "PropertyDetails{" +
                "objectId='" + objectId + '\'' +
                ", address='" + address + '\'' +
                ", city='" + city + '\'' +
                ", state='" + state + '\'' +
                ", zipcode='" + zipcode + '\'' +
                ", type='" + type + '\'' +
                ", bedrooms=" + bedrooms +
                ", bathrooms=" + bathrooms +
                ", squareFeet=" + squareFeet +
                ", rentPrice=" + rentPrice +
                '}';
    }
}
