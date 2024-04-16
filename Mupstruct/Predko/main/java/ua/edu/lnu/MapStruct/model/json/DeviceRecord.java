package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.List;

public class DeviceRecord {
    @JsonProperty("agreementId")
    private String agreementId;

    @JsonProperty("deviceDetails")
    private DeviceDetails deviceDetails;

    @JsonProperty("customerInfos")
    private List<CustomerInfo> customerInfos;


    public String getAgreementId() {
        return agreementId;
    }

    public DeviceDetails getDeviceDetails() {
        return deviceDetails;
    }

    public List<CustomerInfo> getCustomerInfos() {
        return customerInfos;
    }

}