package com.example.demo.CompositePrimaryKeys;

import com.example.demo.Entity.Chats;
import com.example.demo.Entity.Users;

import java.io.Serializable;
import java.util.Objects;

public class ChatMessageId implements Serializable {
    private Chats Chat;
    private Users User;

    public ChatMessageId() {
    }

    public ChatMessageId(Chats chat, Users user) {
        Chat = chat;
        User = user;
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

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        ChatMessageId that = (ChatMessageId) o;
        return Objects.equals(Chat, that.Chat) && Objects.equals(User, that.User);
    }

    @Override
    public int hashCode() {
        return Objects.hash(Chat, User);
    }
}
