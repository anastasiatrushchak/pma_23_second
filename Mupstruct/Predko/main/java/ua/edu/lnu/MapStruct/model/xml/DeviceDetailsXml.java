package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "deviceDetails")
public class DeviceDetailsXml {
    private String deviceId;
    private String agreementStartDate;
    private String agreementEndDate;
    private String deviceModel;
    private String deviceBrand;
    private String deviceYear;

    @XmlElement(name = "deviceId")
    public String getDeviceId() {
        return deviceId;
    }

    public void setDeviceId(String deviceId) {
        this.deviceId = deviceId;
    }

    @XmlElement(name = "agreementStartDate")
    public String getAgreementStartDate() {
        return agreementStartDate;
    }

    public void setAgreementStartDate(String agreementStartDate) {
        this.agreementStartDate = agreementStartDate;
    }

    @XmlElement(name = "agreementEndDate")
    public String getAgreementEndDate() {
        return agreementEndDate;
    }

    public void setAgreementEndDate(String agreementEndDate) {
        this.agreementEndDate = agreementEndDate;
    }

    @XmlElement(name = "deviceModel")
    public String getDeviceModel() {
        return deviceModel;
    }

    public void setDeviceModel(String deviceModel) {
        this.deviceModel = deviceModel;
    }

    @XmlElement(name = "deviceBrand")
    public String getDeviceBrand() {
        return deviceBrand;
    }

    public void setDeviceBrand(String deviceBrand) {
        this.deviceBrand = deviceBrand;
    }

    @XmlElement(name = "deviceYear")
    public String getDeviceYear() {
        return deviceYear;
    }

    public void setDeviceYear(String deviceYear) {
        this.deviceYear = deviceYear;
    }
}
