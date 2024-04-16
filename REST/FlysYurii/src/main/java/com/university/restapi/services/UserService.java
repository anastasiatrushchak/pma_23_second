package com.university.restapi.services;

import com.university.restapi.entities.User;
import com.university.restapi.repositories.UsersRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;


import java.util.List;

@Service
public class UserService {

    @Autowired
    private UsersRepository usersRepository;

    public List<User> getUsers() {
        return usersRepository.findAll();
    }

    public User getUser(Integer id) {
        return usersRepository.findById(id).orElse(null);
    }

    public void addUser(User user) {
        usersRepository.save(user);
    }

    public void updateUser(User user) {
        usersRepository.save(user);
    }

    public void deleteUser(Integer id) {
        usersRepository.deleteById(id);
    }

}
