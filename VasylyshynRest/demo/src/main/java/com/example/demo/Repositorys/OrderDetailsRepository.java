package com.example.demo.Repositorys;

import com.example.demo.Entity.OrderDetails;
import org.springframework.data.repository.CrudRepository;

public interface OrderDetailsRepository extends CrudRepository<OrderDetails, Long> {
}
