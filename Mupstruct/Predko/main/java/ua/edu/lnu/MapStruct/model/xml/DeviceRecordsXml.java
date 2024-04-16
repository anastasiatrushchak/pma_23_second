package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.List;

@XmlRootElement(name = "DeviceRecords")
public class DeviceRecordsXml {
    private List<DeviceRecordXml> deviceRecords;

    @XmlElement(name = "DeviceRecord")
    public List<DeviceRecordXml> getDeviceRecords() {
        return deviceRecords;
    }

    public void setPhoneRecords(List<DeviceRecordXml> deviceRecords) {
        this.deviceRecords = deviceRecords;
    }
}
