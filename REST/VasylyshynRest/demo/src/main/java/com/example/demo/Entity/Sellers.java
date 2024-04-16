package com.example.demo.Entity;

import jakarta.persistence.*;

@Entity
@Table(name = "Sellers")
public class Sellers {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long SellerId;
    @Column(name = "PhoneNumber", length = 13, nullable = false, unique = true)
    private String PhoneNumber;
    private boolean Status;
    private float Rating;
    @Column(name = "Description", length = 10000)
    private String Description;
    @OneToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users Users;

    public Sellers(Long sellerId, String phoneNumber, boolean status, float rating, String description, com.example.demo.Entity.Users users) {
        SellerId = sellerId;
        PhoneNumber = phoneNumber;
        Status = status;
        Rating = rating;
        Description = description;
        Users = users;
    }

    public Sellers() {
    }

    public Long getSellerId() {
        return SellerId;
    }

    public void setSellerId(Long sellerId) {
        SellerId = sellerId;
    }

    public String getPhoneNumber() {
        return PhoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        PhoneNumber = phoneNumber;
    }

    public boolean isStatus() {
        return Status;
    }

    public void setStatus(boolean status) {
        Status = status;
    }

    public float getRating() {
        return Rating;
    }

    public void setRating(float rating) {
        Rating = rating;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public Users getUsers() {
        return Users;
    }

    public void setUsers(Users users) {
        Users = users;
    }
}
