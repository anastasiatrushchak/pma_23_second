package com.example.demo.Repositorys;

import com.example.demo.Entity.Chats;
import org.springframework.data.repository.CrudRepository;

public interface ChatRepository extends CrudRepository<Chats, Long> {
}
