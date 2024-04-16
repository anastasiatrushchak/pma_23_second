package com.example.demo.Controllers;

import com.example.demo.Entity.Users;
import com.example.demo.Errors.UserNotFoundException;
import com.example.demo.Services.Interfaces.UserService;
import org.apache.catalina.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Repository;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.util.Iterator;
import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/user")
public class UserController {
    @Autowired
    private UserService userService;

    @PostMapping
    public Users SaveUser(@Validated  @RequestBody Users user){
        return userService.SaveUser(user);
    }
    @GetMapping
    public Object GetUser (@RequestParam(required = false) Long Id){

        if(Id==null ) {
            return userService.findAllUser();
        }
        return userService.findUserById(Id)
                    .orElseThrow(() -> new UserNotFoundException(Id));


    }
    @DeleteMapping
    private ResponseEntity<String> DeleteUser(@RequestHeader Long Id){
        Users users=userService.findUserById(Id).orElse(null);
        userService.DeleteUserById(Id);

        return ResponseEntity.ok("deleted:"+users);
    }
    @PutMapping("/{Id}")
    private Users PutUser(@RequestBody Users users,@PathVariable Long Id ){
        return userService.findUserById(Id)
                .map(users1 -> {
                    users1.setName((users.getName()));
                    users1.setGender(users.getGender());
                    users1.setEmail(users.getEmail());
                    users1.setDataOfBirth(users.getDataOfBirth());
                    return userService.SaveUser(users1);
                })
                .orElseGet(()->{
                    users.setUserId(Id);
                    return userService.SaveUser(users);
                });
    }
}
