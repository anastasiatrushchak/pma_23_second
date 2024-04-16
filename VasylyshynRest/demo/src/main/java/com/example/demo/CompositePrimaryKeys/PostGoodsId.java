package com.example.demo.CompositePrimaryKeys;

import com.example.demo.Entity.Goods;
import com.example.demo.Entity.Posts;

import java.io.Serializable;
import java.util.Objects;

public class PostGoodsId implements Serializable {
    private Goods Good;
    private Posts Post;

    public PostGoodsId() {
    }

    public PostGoodsId(Goods good, Posts post) {
        Good = good;
        Post = post;
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

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        PostGoodsId that = (PostGoodsId) o;
        return Objects.equals(Good, that.Good) && Objects.equals(Post, that.Post);
    }

    @Override
    public int hashCode() {
        return Objects.hash(Good, Post);
    }
}
