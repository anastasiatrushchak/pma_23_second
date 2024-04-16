package com.ua.edu.lnu.MapStruct;

import com.fasterxml.jackson.databind.SerializationFeature;
import com.fasterxml.jackson.dataformat.xml.XmlMapper;
import com.thoughtworks.xstream.XStream;
import com.ua.edu.lnu.MapStruct.dto.AgreementDto;
import com.ua.edu.lnu.MapStruct.dto.CarDetailsDto;
import com.ua.edu.lnu.MapStruct.dto.CustomerInfoDto;
import com.ua.edu.lnu.MapStruct.entity.Agreement;
import com.ua.edu.lnu.MapStruct.mapper.AgreementDtoMapper;
import com.ua.edu.lnu.MapStruct.mapper.CarDetailsDtoMapper;
import com.ua.edu.lnu.MapStruct.mapper.CustomerInfoDtoMapper;
import com.ua.edu.lnu.MapStruct.repository.AgreementRepository;
import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.Marshaller;
import jakarta.xml.bind.Unmarshaller;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.FileWriter;
import java.io.StringWriter;
import java.sql.SQLOutput;
import java.util.List;

@SpringBootApplication
public class MapStructApplication implements CommandLineRunner {

    @Autowired
    private AgreementRepository repository;

    @Autowired
    private AgreementDtoMapper agreementDtoMapper;

    public static void main(String[] args) {
        SpringApplication.run(MapStructApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        System.out.println("Agreements found with findAll():");
        System.out.println("-------------------------------");

        List<Agreement> agreements = repository.findAll();

//        AgreementDtoMapperImpl agreementDtoMapper = new AgreementDtoMapperImpl();

        JAXBContext jaxbContext = JAXBContext.newInstance(AgreementDto.class);
        Marshaller jaxbMarshaller = jaxbContext.createMarshaller();
        jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

        for (Agreement agreement : agreements) {
            AgreementDto agreementDto = agreementDtoMapper.toDto(agreement);

            StringWriter sw = new StringWriter();
            jaxbMarshaller.marshal(agreementDto, sw);
            String xmlString = sw.toString();

            System.out.println(xmlString);
        }

        for (Agreement agreement: agreements) {
            AgreementDto agreementDto = agreementDtoMapper.toDto(agreement);

            XmlMapper xmlMapper = new XmlMapper();
            String xml = xmlMapper.writeValueAsString(agreementDto);

            System.out.println(xml);
        }

        System.out.println();
        System.out.println("Data saved to file.xml");
    }
}
