package com.example.demo.CompositePrimaryKeys;

import com.example.demo.Entity.Sellers;
import com.example.demo.Entity.Users;
import jakarta.persistence.CascadeType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;

import java.io.Serializable;
import java.util.Objects;

public class FollowsId implements Serializable {
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "SellersId")
    private Sellers Seller;

    public FollowsId() {
    }

    public FollowsId(Users user, Sellers seller) {
        User = user;
        Seller = seller;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        FollowsId followsId = (FollowsId) o;
        return Objects.equals(User, followsId.User) && Objects.equals(Seller, followsId.Seller);
    }

    @Override
    public int hashCode() {
        return Objects.hash(User, Seller);
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
}
