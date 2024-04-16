package ua.edu.lnu.MapStruct.utils;

import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.converter.JsonToXml;
import ua.edu.lnu.MapStruct.model.json.DeviceRecord;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.nio.file.Paths;
import java.util.List;

@Component
public class AppRunner implements CommandLineRunner {

    private final JsonToXml converter;

    public AppRunner(JsonToXml converter) {
        this.converter = converter;
    }

    @Override
    public void run(String... args) throws Exception {
        String filePath = "src/main/resources/device.json";
        String outputFilePath = "src/main/resources/device.xml";

        ObjectMapper mapper = new ObjectMapper();
        List<DeviceRecord> deviceRecords = mapper.readValue(Paths.get(filePath).toFile(),
                mapper.getTypeFactory().constructCollectionType(List.class, DeviceRecord.class));

        converter.convertJsonToXml(deviceRecords, outputFilePath);
    }
}