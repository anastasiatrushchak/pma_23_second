package com.ua.edu.lnu.MapStruct.repository;

import com.ua.edu.lnu.MapStruct.entity.Agreement;
import org.springframework.data.mongodb.repository.MongoRepository;

public interface AgreementRepository extends MongoRepository<Agreement, String>{

    public Agreement findByAgreementId(String agreementId);
}
