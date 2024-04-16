package com.university.restapi.entities;

import jakarta.validation.constraints.Pattern;
import lombok.Data;
import lombok.NoArgsConstructor;

import jakarta.persistence.*;

@Entity
@Table(name="products")
@Data
@NoArgsConstructor
public class Product {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "productid")
    private Integer productId;

    @Column(name = "name")
    @Pattern(regexp = "^[a-zA-Z\\s]*$", message = "Name should contain only alphabets")
    private String name;

    @Column(name = "price")
    @Pattern(regexp = "^[0-9]*$", message = "Price should contain only numbers")
    private double price;
}