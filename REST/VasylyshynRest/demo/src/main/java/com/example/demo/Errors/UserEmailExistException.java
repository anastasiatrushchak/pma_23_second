package com.example.demo.Errors;

import com.example.demo.Entity.Users;

public class UserEmailExistException extends RuntimeException{
    UserEmailExistException(String email){
        super("Email already exist "+email);
    }
}
