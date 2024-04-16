package com.example.demo.Entity;

import jakarta.persistence.*;

@Entity
@Table(name = "Goods")
public class Goods {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long GoodsId;
    @Column(name="GoodsName", length=50, nullable=false, unique = true)
    private String GoodsName;
    @Lob
    @Column(name = "ImageDataGoods", length = 1000)
    private byte[] ImageDataGoods;
    @Column(name = "CurrentPrice", nullable = false)
    private double CurrentPrice;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "CategoryId")
    private Categories categories;

    public Goods(Long goodsId, String goodsName, byte[] imageDataGoods, double currentPrice, Categories categories) {
        GoodsId = goodsId;
        GoodsName = goodsName;
        ImageDataGoods = imageDataGoods;
        CurrentPrice = currentPrice;
        this.categories = categories;
    }

    public Goods() {
    }

    public Long getGoodsId() {
        return GoodsId;
    }

    public void setGoodsId(Long goodsId) {
        GoodsId = goodsId;
    }

    public String getGoodsName() {
        return GoodsName;
    }

    public void setGoodsName(String goodsName) {
        GoodsName = goodsName;
    }

    public byte[] getImageDataGoods() {
        return ImageDataGoods;
    }

    public void setImageDataGoods(byte[] imageDataGoods) {
        ImageDataGoods = imageDataGoods;
    }

    public double getCurrentPrice() {
        return CurrentPrice;
    }

    public void setCurrentPrice(double currentPrice) {
        CurrentPrice = currentPrice;
    }

    public Categories getCategories() {
        return categories;
    }

    public void setCategories(Categories categories) {
        this.categories = categories;
    }
}
