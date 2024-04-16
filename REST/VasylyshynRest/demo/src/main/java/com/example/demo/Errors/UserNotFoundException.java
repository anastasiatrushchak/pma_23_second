package com.example.demo.Errors;

public class UserNotFoundException extends RuntimeException {
    public UserNotFoundException(Long UserId){
        super("Could not find user " + UserId);
    }
}
