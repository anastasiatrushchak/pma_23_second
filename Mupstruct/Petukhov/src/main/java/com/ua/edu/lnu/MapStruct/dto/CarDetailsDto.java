package com.ua.edu.lnu.MapStruct.dto;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import lombok.*;

@XmlRootElement(name = "CarDetails")
public class CarDetailsDto {

    private String carId;

    private String carMake;

    private String carModel;

    private String carYear;

    private String agreementStartDate;

    private String agreementEndDate;

    public CarDetailsDto() {
    }

    public CarDetailsDto(String carId, String carMake, String carModel, String carYear, String agreementStartDate, String agreementEndDate) {
        this.carId = carId;
        this.carMake = carMake;
        this.carModel = carModel;
        this.carYear = carYear;
        this.agreementStartDate = agreementStartDate;
        this.agreementEndDate = agreementEndDate;
    }

    public String getAgreementEndDate() {
        return agreementEndDate;
    }

    public void setAgreementEndDate(String agreementEndDate) {
        this.agreementEndDate = agreementEndDate;
    }

    public String getAgreementStartDate() {
        return agreementStartDate;
    }

    public void setAgreementStartDate(String agreementStartDate) {
        this.agreementStartDate = agreementStartDate;
    }

    public String getCarYear() {
        return carYear;
    }

    public void setCarYear(String carYear) {
        this.carYear = carYear;
    }

    public String getCarModel() {
        return carModel;
    }

    public void setCarModel(String carModel) {
        this.carModel = carModel;
    }

    public String getCarMake() {
        return carMake;
    }

    public void setCarMake(String carMake) {
        this.carMake = carMake;
    }

    public String getCarId() {
        return carId;
    }

    public void setCarId(String carId) {
        this.carId = carId;
    }
}
