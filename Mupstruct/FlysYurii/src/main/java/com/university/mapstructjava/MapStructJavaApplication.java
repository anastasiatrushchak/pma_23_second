package com.university.mapstructjava;

import com.university.mapstructjava.dto.AgreementDto;
import com.university.mapstructjava.entity.Agreement;
import com.university.mapstructjava.mapper.impl.AgreementDtoMapperImpl;
import com.university.mapstructjava.repository.AgreementRepository;
import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.Marshaller;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.StringWriter;
import java.util.List;

@SpringBootApplication
public class MapStructJavaApplication implements CommandLineRunner {

	@Autowired
	private AgreementRepository agreementRepository;

	public static void main(String[] args) {
		SpringApplication.run(MapStructJavaApplication.class, args);
	}

	@Override
	public void run(String... args) throws Exception {
		System.out.println("Agreements found with findAll():");
		System.out.println("-------------------------------");

		List<Agreement> agreements = agreementRepository.findAll();

		for (Agreement agreement : agreements) {
					System.out.println(agreement);
				}
		System.out.println();

		AgreementDtoMapperImpl agreementDtoMapper = new AgreementDtoMapperImpl();

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
	}
}
