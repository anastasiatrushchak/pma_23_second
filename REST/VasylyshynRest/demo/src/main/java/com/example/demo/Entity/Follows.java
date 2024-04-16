package com.example.demo.Entity;

import com.example.demo.CompositePrimaryKeys.FollowsId;
import jakarta.persistence.*;

import java.time.LocalDate;

@Entity
@Table(name = "Follows")
@IdClass(FollowsId.class)
public class Follows {
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "SellersId")
    private Sellers Seller;
    private LocalDate CreatedAt;

    public Follows(Users user, Sellers seller, LocalDate createdAt) {
        User = user;
        Seller = seller;
        CreatedAt = createdAt;
    }

    public Follows() {
    }

    public Users getUser() {
        return User;
    }

    public void setUser(Users user) {
        User = user;
    }

    public Sellers getSeller() {
        return Seller;
    }

    public void setSeller(Sellers seller) {
        Seller = seller;
    }

    public LocalDate getCreatedAt() {
        return CreatedAt;
    }

    public void setCreatedAt(LocalDate createdAt) {
        CreatedAt = createdAt;
    }
}
