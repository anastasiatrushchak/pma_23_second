package com.example.demo.Entity;

import com.example.demo.CompositePrimaryKeys.ChatMessageId;
import jakarta.persistence.*;

@Entity
@Table(name = "ChatMessage")
@IdClass(ChatMessageId.class)
public class ChatMessage {
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "ChatId")
    private Chats Chat;
    @Id
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "UserId")
    private Users User;
    @Column(name = "Text", length = 200, nullable = false)
    private String Text;

    public ChatMessage(Chats chat, Users user, String text) {
        Chat = chat;
        User = user;
        Text = text;
    }

    public ChatMessage() {
    }

    public Chats getChat() {
        return Chat;
    }

    public void setChat(Chats chat) {
        Chat = chat;
    }

    public Users getUser() {
        return User;
    }

    public void setUser(Users user) {
        User = user;
    }

    public String getText() {
        return Text;
    }

    public void setText(String text) {
        Text = text;
    }
}
