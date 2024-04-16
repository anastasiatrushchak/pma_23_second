package com.university.restapi.entities;

import jakarta.validation.constraints.Pattern;
import lombok.Data;
import lombok.NoArgsConstructor;

import jakarta.persistence.*;

@Entity
@Table(name = "orders")
@Data
@NoArgsConstructor
public class Order {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "orderid")
    private Integer orderId;

    @ManyToOne
    @JoinColumn(name = "userid")
    @Pattern(regexp = "^[0-9]*$", message = "User ID should contain only numbers")
    private User user;

    @ManyToOne
    @JoinColumn(name = "productid")
    @Pattern(regexp = "^[0-9]*$", message = "Product ID should contain only numbers")
    private Product product;

    @Column(name = "quantity")
    @Pattern(regexp = "^[0-9]*$", message = "Quantity should contain only numbers")
    private Integer quantity;
}
