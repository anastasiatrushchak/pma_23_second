package com.example.demo.Entity;

import jakarta.persistence.*;

@Entity
@Table(name = "Basket")
public class Basket {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long BasketId;
    @Column(name = "Quantity", nullable = false)
    private int Quantity;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Goods;

    public Basket(Long basketId, int quantity, Users user, com.example.demo.Entity.Goods goods) {
        BasketId = basketId;
        Quantity = quantity;
        User = user;
        Goods = goods;
    }

    public Basket() {
    }

    public Long getBasketId() {
        return BasketId;
    }

    public void setBasketId(Long basketId) {
        BasketId = basketId;
    }

    public int getQuantity() {
        return Quantity;
    }

    public void setQuantity(int quantity) {
        Quantity = quantity;
    }

    public Users getUser() {
        return User;
    }

    public void setUser(Users user) {
        User = user;
    }

    public com.example.demo.Entity.Goods getGoods() {
        return Goods;
    }

    public void setGoods(com.example.demo.Entity.Goods goods) {
        Goods = goods;
    }
}
