package com.ua.edu.lnu.MapStruct.entity;

import lombok.*;
import org.springframework.data.mongodb.core.mapping.Document;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ToString
public class CustomerInfo {

    private String agreementActiveAt;
    private String agreementCreatedOn;
    private String agreementType;
    private String customerAddress;
    private String customerContact;
    private String customerLicense;
    private String customerName;
    private String customerPhone;
}
