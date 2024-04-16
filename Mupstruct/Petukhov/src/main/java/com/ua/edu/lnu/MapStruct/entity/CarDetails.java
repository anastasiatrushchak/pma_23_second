package com.ua.edu.lnu.MapStruct.entity;

import lombok.*;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.mongodb.core.mapping.DocumentReference;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ToString
public class CarDetails {

    private String agreementEndDate;
    private String agreementStartDate;
    private String carId;
    private String carMake;
    private String carModel;
    private String carYear;
}
