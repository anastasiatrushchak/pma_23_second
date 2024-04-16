package com.university.restapi.services;

import com.university.restapi.entities.Product;
import com.university.restapi.repositories.ProductsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProductsService {


    @Autowired
    private ProductsRepository productsRepository;

    public List<Product> getProducts() {
        return productsRepository.findAll();
    }

    public Product getProduct(Integer id) {
        return productsRepository.findById(id).orElse(null);
    }

    public void addProduct(Product product) {
        productsRepository.save(product);
    }

    public void updateProduct(Product product) {
        productsRepository.save(product);
    }

    public void deleteProduct(Integer id) {
        productsRepository.deleteById(id);
    }
}
