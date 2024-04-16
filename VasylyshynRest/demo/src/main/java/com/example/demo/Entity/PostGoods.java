package com.example.demo.Entity;

import com.example.demo.CompositePrimaryKeys.PostGoodsId;
import jakarta.persistence.*;

@Entity
@Table(name = "PostGoods")
@IdClass(PostGoodsId.class)
public class PostGoods {
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Good;
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "PostId")
    private Posts Post;

    public PostGoods(Goods good, Posts post) {
        Good = good;
        Post = post;
    }

    public PostGoods() {
    }

    public Goods getGood() {
        return Good;
    }

    public void setGood(Goods good) {
        Good = good;
    }

    public Posts getPost() {
        return Post;
    }

    public void setPost(Posts post) {
        Post = post;
    }
}
