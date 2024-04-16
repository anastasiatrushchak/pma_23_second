package com.example.demo.Services.Interfaces;

import com.example.demo.Entity.Users;
import org.apache.catalina.User;

import java.util.List;
import java.util.Optional;

public interface UserService {
    //save
    Users SaveUser(Users users);
    //read
    List<Users> fetchUsersList();
    //update
    Users updateUsers(Users users, Long Id);
    //delete
    void DeleteUserById(Long UserId);
    Optional<Users> findUserById(Long Id);
    Iterable<Users> findAllUser();


}
