package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.List;

public class PhoneRecord {
    @JsonProperty("phoneId")
    private String phoneId;

    @JsonProperty("phoneDetails")
    private PhoneDetails phoneDetails;

    @JsonProperty("userDetails")
    private List<UserDetails> userDetails;


    public String getPhoneId() {
        return phoneId;
    }

    public PhoneDetails getPhoneDetails() {
        return phoneDetails;
    }

    public List<UserDetails> getUserDetails() {
        return userDetails;
    }

}