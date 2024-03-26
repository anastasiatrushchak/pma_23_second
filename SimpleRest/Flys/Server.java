package com.example.restapi;

import org.springframework.web.bind.annotation.*;

@RestController
public class Server {
    @GetMapping("/server")
    public String hello() {
        return "Hello, world!";
    }

    @PostMapping("/byBody")
    public String postBody(@RequestBody Name name) {
        try {
            if (name.getName().isEmpty()) {
                throw new IllegalArgumentException("Name cannot be empty");
            }
            if (name.getName().matches(".*\\d.*")) {
                throw new IllegalArgumentException("Name cannot contain numbers");
            }
            return "Hello, " + name.getName() + "!";
        } catch (IllegalArgumentException e) {
            return e.getMessage();

        }

    }

    @PostMapping("/byParam")
    public String postParam(@RequestParam Name name) {
        try {
            if (name.getName().isEmpty()) {
                throw new IllegalArgumentException("Name cannot be empty");
            }
            if (name.getName().matches(".*\\d.*")) {
                throw new IllegalArgumentException("Name cannot contain numbers");
            }
            return "Hello, " + name + "!";
        } catch (IllegalArgumentException e) {
            return e.getMessage();

        }
    }

    @PostMapping("/byHeader")
    public String postHeader(@RequestHeader("name") Name name) {
        try {
            if (name.getName().isEmpty()) {
                throw new IllegalArgumentException("Name cannot be empty");
            }
            if (name.getName().matches(".*\\d.*")) {
                throw new IllegalArgumentException("Name cannot contain numbers");
            }
            return "Hello, " + name.getName() + "!";
        } catch (IllegalArgumentException e) {
            return e.getMessage();

        }
    }

    public static class Name {
        private String name;

        public String getName() {
            return name;
        }
    }

}
