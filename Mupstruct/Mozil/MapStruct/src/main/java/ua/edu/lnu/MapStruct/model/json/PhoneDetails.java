package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class PhoneDetails {
    @JsonProperty("modelId")
    private String modelId;

    @JsonProperty("phoneStartDate")
    private String phoneStartDate;

    @JsonProperty("phoneEndDate")
    private String phoneEndDate;

    @JsonProperty("phoneModel")
    private String phoneModel;

    @JsonProperty("phoneBrand")
    private String phoneBrand;

    @JsonProperty("phoneYear")
    private String phoneYear;


    public String getModelId() {
        return modelId;
    }

    public String getPhoneStartDate() {
        return phoneStartDate;
    }

    public String getPhoneEndDate() {
        return phoneEndDate;
    }

    public String getPhoneModel() {
        return phoneModel;
    }

    public String getPhoneBrand() {
        return phoneBrand;
    }

    public String getPhoneYear() {
        return phoneYear;
    }
}
