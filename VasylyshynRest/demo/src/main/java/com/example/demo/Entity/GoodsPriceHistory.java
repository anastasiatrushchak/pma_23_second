package com.example.demo.Entity;

import jakarta.persistence.*;

import java.util.Date;

@Entity
@Table(name = "GoodsPriceHistory")
public class GoodsPriceHistory {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long GoodsPriceHistoryId;
    @Column(name = "Price", nullable = false)
    private double Price;
    @Column(name = "Date", nullable = false)
    private Date date;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Goods;

    public GoodsPriceHistory(Long goodsPriceHistoryId, double price, Date date, com.example.demo.Entity.Goods goods) {
        GoodsPriceHistoryId = goodsPriceHistoryId;
        Price = price;
        this.date = date;
        Goods = goods;
    }

    public GoodsPriceHistory() {
    }

    public Long getGoodsPriceHistoryId() {
        return GoodsPriceHistoryId;
    }

    public void setGoodsPriceHistoryId(Long goodsPriceHistoryId) {
        GoodsPriceHistoryId = goodsPriceHistoryId;
    }

    public double getPrice() {
        return Price;
    }

    public void setPrice(double price) {
        Price = price;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public com.example.demo.Entity.Goods getGoods() {
        return Goods;
    }

    public void setGoods(com.example.demo.Entity.Goods goods) {
        Goods = goods;
    }
}
