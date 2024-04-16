package org.universe;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.google.gson.internal.bind.util.ISO8601Utils;
import com.mongodb.client.*;
import org.bson.Document;
import org.universe.Mappers.DataMapper;
import org.universe.Models.ModelXML.DataXMLModel;
import org.universe.Models.ModelsJson.DataModelJson;
import org.universe.Models.ModelsJson.InfoModelJson;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.SchemaOutputResolver;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

import static org.universe.Constants.DBConstants.*;

public class Main {
    public static void main(String[] args) throws JAXBException, JsonProcessingException {
        MongoClient mongoClient = MongoClients.create(UrlConnectionToMongoDB);
        MongoDatabase database = mongoClient.getDatabase(DBName);
        System.out.println("Назва бази даних: " + database.getName());
        MongoCollection<Document> collection = database.getCollection(DBCollectionName);
        System.out.println("Колекція: " + collection.getNamespace().getCollectionName());
        MongoCursor<Document> cursor = collection.find().iterator();
        while (cursor.hasNext()) {
            System.out.println("data bases data:");
            Document document = cursor.next();
            System.out.println(document + "\n");
            System.out.println(document.get("_id"));
        }
        cursor.close();
        MongoCursor<Document> cursorr = collection.find().iterator();
        ObjectMapper mapper = new ObjectMapper();
        try {
            JAXBContext context = JAXBContext.newInstance(DataXMLModel.class);
            Marshaller marshaller = context.createMarshaller();
            marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
            File file = new File("data2.xml");
            FileWriter writer = new FileWriter(file);
            System.out.println("Ну погнали");
            while (cursorr.hasNext()) {
                Document document = cursorr.next();
                DataModelJson dataModelJson = mapper.readValue(document.toJson(), DataModelJson.class);
                DataMapper dataMapper = DataMapper.INSTANCE;
                DataXMLModel dataXMLModel = dataMapper.toDataModelJson(dataModelJson);
                System.out.println("перший пішов");
                marshaller.marshal(dataXMLModel, writer);
            }
            writer.close();

            System.out.println("Ну бляха походу єєєєє!!!!!!!!!!!!");
        } catch (IOException e) {
            e.printStackTrace();
        } catch (JAXBException e) {
            e.printStackTrace();
        }
        cursorr.close();


    }
}