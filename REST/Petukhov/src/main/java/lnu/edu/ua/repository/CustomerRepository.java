package lnu.edu.ua.repository;

import lnu.edu.ua.model.entity.Customer;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CustomerRepository extends JpaRepository<Customer, Long> {

        Customer findByCustomerID(Long customerID);
        Customer deleteCustomerByCustomerID(Long customerID);
}
