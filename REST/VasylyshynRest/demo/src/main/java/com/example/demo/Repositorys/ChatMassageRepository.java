package com.example.demo.Repositorys;

import com.example.demo.Entity.ChatMessage;
import org.springframework.data.repository.CrudRepository;

public interface ChatMassageRepository extends CrudRepository<ChatMessage, Long> {
}
