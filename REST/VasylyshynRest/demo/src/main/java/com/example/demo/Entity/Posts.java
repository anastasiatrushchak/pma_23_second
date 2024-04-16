package com.example.demo.Entity;

import jakarta.persistence.*;
import org.apache.catalina.User;

import java.time.LocalDate;

@Entity
@Table(name = "Posts")
public class Posts {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long PostId;
    @Column(name = "Title", length = 50, nullable = false)
    private String Title;
    private boolean Status;
    private LocalDate CreatedAt;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users Users;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "GoodsId")
    private Goods Goods;

    public Posts(Long postId, String title, boolean status, LocalDate createdAt, com.example.demo.Entity.Users users, com.example.demo.Entity.Goods goods) {
        PostId = postId;
        Title = title;
        Status = status;
        CreatedAt = createdAt;
        Users = users;
        Goods = goods;
    }

    public Posts() {
    }

    public Long getPostId() {
        return PostId;
    }

    public void setPostId(Long postId) {
        PostId = postId;
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public boolean isStatus() {
        return Status;
    }

    public void setStatus(boolean status) {
        Status = status;
    }

    public LocalDate getCreatedAt() {
        return CreatedAt;
    }

    public void setCreatedAt(LocalDate createdAt) {
        CreatedAt = createdAt;
    }

    public com.example.demo.Entity.Users getUsers() {
        return Users;
    }

    public void setUsers(com.example.demo.Entity.Users users) {
        Users = users;
    }

    public com.example.demo.Entity.Goods getGoods() {
        return Goods;
    }

    public void setGoods(com.example.demo.Entity.Goods goods) {
        Goods = goods;
    }
}
