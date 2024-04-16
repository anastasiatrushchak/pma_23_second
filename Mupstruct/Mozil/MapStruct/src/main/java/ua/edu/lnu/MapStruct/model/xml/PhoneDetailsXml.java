package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "PhoneDetails")
public class PhoneDetailsXml {
    private String modelId;
    private String phoneStartDate;
    private String phoneEndDate;
    private String phoneModel;
    private String phoneBrand;
    private String phoneYear;

    @XmlElement(name = "modelId")
    public String getModelId() {
        return modelId;
    }

    public void setModelId(String modelId) {
        this.modelId = modelId;
    }

    @XmlElement(name = "phoneStartDate")
    public String getPhoneStartDate() {
        return phoneStartDate;
    }

    public void setPhoneStartDate(String phoneStartDate) {
        this.phoneStartDate = phoneStartDate;
    }

    @XmlElement(name = "phoneEndDate")
    public String getPhoneEndDate() {
        return phoneEndDate;
    }

    public void setPhoneEndDate(String phoneEndDate) {
        this.phoneEndDate = phoneEndDate;
    }

    @XmlElement(name = "phoneModel")
    public String getPhoneModel() {
        return phoneModel;
    }

    public void setPhoneModel(String phoneModel) {
        this.phoneModel = phoneModel;
    }

    @XmlElement(name = "phoneBrand")
    public String getPhoneBrand() {
        return phoneBrand;
    }

    public void setPhoneBrand(String phoneBrand) {
        this.phoneBrand = phoneBrand;
    }

    @XmlElement(name = "phoneYear")
    public String getPhoneYear() {
        return phoneYear;
    }

    public void setPhoneYear(String phoneYear) {
        this.phoneYear = phoneYear;
    }
}