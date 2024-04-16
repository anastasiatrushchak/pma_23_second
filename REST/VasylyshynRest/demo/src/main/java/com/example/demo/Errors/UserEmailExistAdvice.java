package com.example.demo.Errors;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.ResponseStatus;

@ControllerAdvice
public class UserEmailExistAdvice {
    @ResponseBody
    @ExceptionHandler(UserEmailExistException.class)
    @ResponseStatus(HttpStatus.CONFLICT)
    String userEmailExistHandler(UserEmailExistException ex){
        return ex.getMessage();
    }

}
