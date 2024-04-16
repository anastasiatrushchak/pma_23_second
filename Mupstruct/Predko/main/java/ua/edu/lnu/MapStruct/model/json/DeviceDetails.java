package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class DeviceDetails {
    @JsonProperty("deviceId")
    private String deviceId;

    @JsonProperty("agreementStartDate")
    private String agreementStartDate;

    @JsonProperty("agreementEndDate")
    private String agreementEndDate;

    @JsonProperty("deviceModel")
    private String deviceModel;

    @JsonProperty("deviceBrand")
    private String deviceBrand;

    @JsonProperty("deviceYear")
    private String deviceYear;


    public String getDeviceId() {
        return deviceId;
    }

    public String getAgreementStartDate() {
        return agreementStartDate;
    }

    public String getAgreementEndDate() {
        return agreementEndDate;
    }

    public String getDeviceModel() {
        return deviceModel;
    }

    public String getDeviceBrand() {
        return deviceBrand;
    }

    public String getDeviceYear() {
        return deviceYear;
    }
}