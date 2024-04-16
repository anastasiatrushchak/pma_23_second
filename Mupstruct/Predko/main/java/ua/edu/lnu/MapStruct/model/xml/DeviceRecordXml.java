package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "DeviceRecord")
public class DeviceRecordXml {
    private String agreementId;
    private DeviceDetailsXml deviceDetails;
    private List<CustomerInfoXml> customerInfo;

    @XmlElement(name = "deviceId")
    public String getAgreementId() {
        return agreementId;
    }

    public void setAgreementId(String agreementId) {
        this.agreementId = agreementId;
    }

    @XmlElement(name = "deviceDetails")
    public DeviceDetailsXml getDeviceDetails() {
        return deviceDetails;
    }

    public void setDeviceDetails(DeviceDetailsXml deviceDetails) {
        this.deviceDetails = deviceDetails;
    }

    @XmlElement(name = "customerInfo")
    public List<CustomerInfoXml> getCustomerInfos() {
        return customerInfo;
    }

    public void setCustomerInfo(List<CustomerInfoXml> customerInfo) {
        this.customerInfo = customerInfo;
    }
}