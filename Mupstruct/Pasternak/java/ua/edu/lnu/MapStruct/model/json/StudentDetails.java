package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class StudentDetails {
    @JsonProperty("firstName")
    private String firstName;

    @JsonProperty("lastName")
    private String lastName;

    @JsonProperty("email")
    private String email;

    @JsonProperty("phone")
    private String phone;

    @JsonProperty("address")
    private String address;

    @JsonProperty("city")
    private String city;

    @JsonProperty("age")
    private String age;

    @JsonProperty("bithday")
    private String bithday;


    public String getfirstName() {
        return firstName;
    }

    public String getlastName() {
        return lastName;
    }

    public String getemail() {
        return email;
    }

    public String getphone() {
        return phone;
    }

    public String getaddress() {
        return address;
    }

    public String getcity() {
        return city;
    }

    public String getage() {
        return age;
    }

    public String getbithday() {
        return bithday;
    }
}