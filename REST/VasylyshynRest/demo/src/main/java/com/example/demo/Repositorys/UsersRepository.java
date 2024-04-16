package com.example.demo.Repositorys;

import com.example.demo.Entity.Users;
import org.springframework.data.repository.CrudRepository;

import java.util.Optional;

public interface UsersRepository extends CrudRepository<Users, Long> {
}
