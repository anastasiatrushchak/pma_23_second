package com.university.mapstructjava.repository;

import com.university.mapstructjava.entity.Agreement;
import org.springframework.data.mongodb.repository.MongoRepository;

public interface AgreementRepository extends MongoRepository<Agreement, String> {

        public Agreement findByAgreementId(String agreementId);
}