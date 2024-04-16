package com.example.demo.Entity;

import jakarta.persistence.*;

@Entity
@Table(name = "OrderDetails")

public class OrderDetails {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long OrderDetailsId;
    @Column(nullable = false)
    private int Quantity;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "OrderId")
    private Orders Order;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Goods;

    public OrderDetails(Long orderDetailsId, int quantity, Orders order, com.example.demo.Entity.Goods goods) {
        OrderDetailsId = orderDetailsId;
        Quantity = quantity;
        Order = order;
        Goods = goods;
    }

    public OrderDetails() {
    }

    public Long getOrderDetailsId() {
        return OrderDetailsId;
    }

    public void setOrderDetailsId(Long orderDetailsId) {
        OrderDetailsId = orderDetailsId;
    }

    public int getQuantity() {
        return Quantity;
    }

    public void setQuantity(int quantity) {
        Quantity = quantity;
    }

    public Orders getOrder() {
        return Order;
    }

    public void setOrder(Orders order) {
        Order = order;
    }

    public com.example.demo.Entity.Goods getGoods() {
        return Goods;
    }

    public void setGoods(com.example.demo.Entity.Goods goods) {
        Goods = goods;
    }
}
