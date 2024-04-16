package com.university.restapi.services;

import com.university.restapi.repositories.OrdersRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.university.restapi.entities.Order;

import java.util.List;


@Service
public class OrdersService {

    @Autowired
    private OrdersRepository ordersRepository;

    public List<Order> getOrders() {
        return ordersRepository.findAll();
    }

    public Order getOrder(Integer id) {
        return ordersRepository.findById(id).orElse(null);
    }

    public void addOrder(Order order) {
        ordersRepository.save(order);
    }

    public void updateOrder(Order order) {
        ordersRepository.save(order);
    }

    public void deleteOrder(Integer id) {
        ordersRepository.deleteById(id);
    }
}

