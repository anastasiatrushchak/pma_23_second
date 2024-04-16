package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "StudentDetails")
public class StudentDetailsXml {
    private String firstName;
    private String lastName;
    private String email;
    private String phone;
    private String address;
    private String city;
    private String age;
    private String bithday;

    @XmlElement(name = "firstName")
    public String getfirstName() {
        return firstName;
    }

    public void setfirstName(String firstName) {
        this.firstName = firstName;
    }

    @XmlElement(name = "lastName")
    public String getlastName() {
        return lastName;
    }

    public void setlastName(String lastName) {
        this.lastName = lastName;
    }

    @XmlElement(name = "email")
    public String getemail() {
        return email;
    }

    public void setemail(String email) {
        this.email = email;
    }

    @XmlElement(name = "phone")
    public String getphone() {
        return phone;
    }

    public void setphone(String phone) {
        this.phone = phone;
    }

    @XmlElement(name = "address")
    public String getaddress() {
        return address;
    }

    public void setaddress(String address) {
        this.address = address;
    }

    @XmlElement(name = "city")
    public String getcity() {
        return city;
    }

    public void setcity(String city) {
        this.city = city;
    }

    @XmlElement(name = "age")
    public String getage() {
        return age;
    }

    public void setage(String age) {
        this.age = age;
    }

    @XmlElement(name = "bithday")
    public String getbithday() {
        return bithday;
    }

    public void setbithday(String bithday) {
        this.bithday = bithday;
    }
}