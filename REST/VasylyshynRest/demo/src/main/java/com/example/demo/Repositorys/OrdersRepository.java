package com.example.demo.Repositorys;

import com.example.demo.Entity.Orders;
import org.springframework.data.repository.CrudRepository;

public interface OrdersRepository extends CrudRepository<Orders, Long> {
}
