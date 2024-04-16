package lnu.edu.ua.repository;

import lnu.edu.ua.model.entity.Agreement;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AgreementRepository extends JpaRepository<Agreement, Long> {

    Agreement findByAgreementID(Long agreementID);

    Agreement deleteAgreementByAgreementID(Long agreementID);
}
