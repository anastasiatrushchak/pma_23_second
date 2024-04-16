package ua.edu.lnu.MapStruct.converter;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.mapper.DeviceDetailsMapper;
import ua.edu.lnu.MapStruct.mapper.DeviceRecordMapper;
import ua.edu.lnu.MapStruct.mapper.CustomerInfoMapper;
import ua.edu.lnu.MapStruct.model.json.DeviceRecord;
import ua.edu.lnu.MapStruct.model.xml.DeviceRecordXml;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.Marshaller;
import ua.edu.lnu.MapStruct.model.xml.DeviceRecordsXml;

import java.io.File;
import java.util.List;
import java.util.stream.Collectors;

@Component
public class JsonToXml {

    private final DeviceDetailsMapper deviceDetailsMapper;
    private final DeviceRecordMapper deviceRecordMapper;
    private final CustomerInfoMapper customerInfoMapper;

    @Autowired
    public JsonToXml(DeviceDetailsMapper deviceDetailsMapper, DeviceRecordMapper deviceRecordMapper, CustomerInfoMapper customerInfoMapper) {
        this.deviceDetailsMapper = deviceDetailsMapper;
        this.deviceRecordMapper = deviceRecordMapper;
        this.customerInfoMapper = customerInfoMapper;
    }

    public void convertJsonToXml(List<DeviceRecord> deviceRecords, String outputFilePath) throws Exception {
        List<DeviceRecordXml> deviceRecordXmls = deviceRecords.stream()
                .map(record -> {
                    DeviceRecordXml deviceRecordXml = deviceRecordMapper.toXml(record);
                    deviceRecordXml.setDeviceDetails(deviceDetailsMapper.toXml(record.getDeviceDetails()));
                    deviceRecordXml.setCustomerInfo(record.getCustomerInfos().stream()
                            .map(customerInfoMapper::toXml)
                            .collect(Collectors.toList()));
                    return deviceRecordXml;
                })
                .collect(Collectors.toList());

        DeviceRecordsXml deviceRecordsXml = new DeviceRecordsXml();
        deviceRecordsXml.setPhoneRecords(deviceRecordXmls);

        JAXBContext context = JAXBContext.newInstance(DeviceRecordsXml.class);
        Marshaller marshaller = context.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);

        marshaller.marshal(deviceRecordsXml, new File(outputFilePath));
    }
}