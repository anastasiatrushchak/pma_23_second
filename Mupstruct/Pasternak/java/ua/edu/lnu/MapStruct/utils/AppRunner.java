package ua.edu.lnu.MapStruct.utils;

import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;
import ua.edu.lnu.MapStruct.converter.JsonToXmlConverter;
import ua.edu.lnu.MapStruct.model.json.SubjectRecord;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.nio.file.Paths;
import java.util.List;

@Component
public class AppRunner implements CommandLineRunner {

    private final JsonToXmlConverter converter;

    public AppRunner(JsonToXmlConverter converter) {
        this.converter = converter;
    }

    @Override
    public void run(String... args) throws Exception {
        String filePath = "src/main/resources/SubjcountHours.json";
        String outputFilePath = "src/main/resources/SubjcountHours.xml";

        ObjectMapper mapper = new ObjectMapper();
        List<SubjectRecord> SubjectRecords = mapper.readValue(Paths.get(filePath).toFile(),
                mapper.getTypeFactory().constructCollectionType(List.class, SubjectRecord.class));

        converter.convertJsonToXml(SubjectRecords, outputFilePath);
    }
}