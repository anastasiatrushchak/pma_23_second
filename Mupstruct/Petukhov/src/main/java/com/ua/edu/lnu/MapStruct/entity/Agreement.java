package com.ua.edu.lnu.MapStruct.entity;

import lombok.*;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.mongodb.core.mapping.MongoId;

import java.util.ArrayList;
import java.util.List;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ToString
@Document(collection = "public")
public class Agreement {

    @MongoId
    private String id;

    private String agreementId;

    private ArrayList<CarDetails> carDetails;

    private ArrayList<CustomerInfo> customerInfo;
}
