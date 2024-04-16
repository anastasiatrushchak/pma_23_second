package com.example.demo.Entity;

import jakarta.persistence.*;

import java.util.Date;

@Entity
@Table(name = "Orders")
public class Orders {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long OrderId;
    private Date CreatedAt;
    @Column(name = "DeliveryAddress ", length = 100, nullable = false)
    private String DeliveryAddress;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;

    public Orders(Long orderId, Date createdAt, String deliveryAddress, Users user) {
        OrderId = orderId;
        CreatedAt = createdAt;
        DeliveryAddress = deliveryAddress;
        User = user;
    }

    public Orders() {
    }

    public Long getOrderId() {
        return OrderId;
    }

    public void setOrderId(Long orderId) {
        OrderId = orderId;
    }

    public Date getCreatedAt() {
        return CreatedAt;
    }

    public void setCreatedAt(Date createdAt) {
        CreatedAt = createdAt;
    }

    public String getDeliveryAddress() {
        return DeliveryAddress;
    }

    public void setDeliveryAddress(String deliveryAddress) {
        DeliveryAddress = deliveryAddress;
    }

    public Users getUser() {
        return User;
    }

    public void setUser(Users user) {
        User = user;
    }
}
