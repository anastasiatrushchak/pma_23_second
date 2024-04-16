package com.example.demo.Entity;

import jakarta.persistence.*;

import java.time.LocalDate;

@Entity
@Table(name = "Chats")
public class Chats {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long ChatId;
    private LocalDate CreatedAt;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "SellersId")
    private Sellers Seller;

    public Chats(Long chatId, LocalDate createdAt, Users user, Sellers seller) {
        ChatId = chatId;
        CreatedAt = createdAt;
        User = user;
        Seller = seller;
    }

    public Chats() {
    }

    public Long getChatId() {
        return ChatId;
    }

    public void setChatId(Long chatId) {
        ChatId = chatId;
    }

    public LocalDate getCreatedAt() {
        return CreatedAt;
    }

    public void setCreatedAt(LocalDate createdAt) {
        CreatedAt = createdAt;
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
