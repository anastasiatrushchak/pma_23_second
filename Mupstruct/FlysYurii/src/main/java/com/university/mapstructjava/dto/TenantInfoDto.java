package com.university.mapstructjava.dto;

import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "TenantInfo")
public class TenantInfoDto {
    private String tenantName;
    private String tenantEmail;
    private String tenantPhone;
    private String tenantOccupation;
    private Long tenantAge;
    private Long tenantCreditScore;
    private String agreementDate;
    private String agreementStartDate;
    private String agreementEndDate;
    private String agreementType;
    private String additionalTerms;

    public TenantInfoDto() {
    }

    public TenantInfoDto(String tenantName, String tenantEmail, String tenantPhone, String tenantOccupation, Long tenantAge, Long tenantCreditScore, String agreementDate, String agreementStartDate, String agreementEndDate, String agreementType, String additionalTerms) {
        this.tenantName = tenantName;
        this.tenantEmail = tenantEmail;
        this.tenantPhone = tenantPhone;
        this.tenantOccupation = tenantOccupation;
        this.tenantAge = tenantAge;
        this.tenantCreditScore = tenantCreditScore;
        this.agreementDate = agreementDate;
        this.agreementStartDate = agreementStartDate;
        this.agreementEndDate = agreementEndDate;
        this.agreementType = agreementType;
        this.additionalTerms = additionalTerms;
    }

    public String gettenantName() {
        return tenantName;
    }

    public void setTenantName(String tenantName) {
        this.tenantName = tenantName;
    }

    public String getTenantEmail() {
        return tenantEmail;
    }

    public void setTenantEmail(String tenantEmail) {
        this.tenantEmail = tenantEmail;
    }

    public String getTenantPhone() {
        return tenantPhone;
    }

    public void setTenantPhone(String tenantPhone) {
        this.tenantPhone = tenantPhone;
    }

    public String getTenantOccupation() {
        return tenantOccupation;
    }

    public void setTenantOccupation(String tenantOccupation) {
        this.tenantOccupation = tenantOccupation;
    }

    public Long getTenantAge() {
        return tenantAge;
    }

    public void setTenantAge(Long tenantAge) {
        this.tenantAge = tenantAge;
    }

    public Long getTenantCreditScore() {
        return tenantCreditScore;
    }

    public void setTenantCreditScore(Long tenantCreditScore) {
        this.tenantCreditScore = tenantCreditScore;
    }

    public String getAgreementDate() {
        return agreementDate;
    }

    public void setAgreementDate(String agreementDate) {
        this.agreementDate = agreementDate;
    }

    public String getAgreementStartDate() {
        return agreementStartDate;
    }

    public void setAgreementStartDate(String agreementStartDate) {
        this.agreementStartDate = agreementStartDate;
    }

    public String getAgreementEndDate() {
        return agreementEndDate;
    }

    public void setAgreementEndDate(String agreementEndDate) {
        this.agreementEndDate = agreementEndDate;
    }

    public String getAgreementType() {
        return agreementType;
    }

    public void setAgreementType(String agreementType) {
        this.agreementType = agreementType;
    }

    public String getAdditionalTerms() {
        return additionalTerms;
    }

    public void setAdditionalTerms(String additionalTerms) {
        this.additionalTerms = additionalTerms;
    }
}
