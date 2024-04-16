package com.example.demo.Entity;

import jakarta.persistence.*;

import java.util.Date;

@Entity
@Table(name = "Prices")
public class Prices {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long PricesId;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Goods;
    private Date Date;
    private double Price;

    public Prices(Long pricesId, com.example.demo.Entity.Goods goods, java.util.Date date, double price) {
        PricesId = pricesId;
        Goods = goods;
        Date = date;
        Price = price;
    }

    public Prices() {
    }

    public Long getPricesId() {
        return PricesId;
    }

    public void setPricesId(Long pricesId) {
        PricesId = pricesId;
    }

    public com.example.demo.Entity.Goods getGoods() {
        return Goods;
    }

    public void setGoods(com.example.demo.Entity.Goods goods) {
        Goods = goods;
    }

    public java.util.Date getDate() {
        return Date;
    }

    public void setDate(java.util.Date date) {
        Date = date;
    }

    public double getPrice() {
        return Price;
    }

    public void setPrice(double price) {
        Price = price;
    }
}
