package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class UserDetails {
    @JsonProperty("userName")
    private String userName;

    @JsonProperty("userContact")
    private String userContact;

    @JsonProperty("userActiveAt")
    private String userActiveAt;

    @JsonProperty("userCreatedOn")
    private String userCreatedOn;

    @JsonProperty("userType")
    private String userType;

    @JsonProperty("userAddress")
    private String userAddress;

    @JsonProperty("userPhone")
    private String userPhone;

    @JsonProperty("userLicense")
    private String userLicense;


    public String getUserName() {
        return userName;
    }

    public String getUserContact() {
        return userContact;
    }

    public String getUserActiveAt() {
        return userActiveAt;
    }

    public String getUserCreatedOn() {
        return userCreatedOn;
    }

    public String getUserType() {
        return userType;
    }

    public String getUserAddress() {
        return userAddress;
    }

    public String getUserPhone() {
        return userPhone;
    }

    public String getUserLicense() {
        return userLicense;
    }
}