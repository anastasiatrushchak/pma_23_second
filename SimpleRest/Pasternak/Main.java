package org.example;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.*;

@SpringBootApplication
@RestController
public class Main {

    public static void main(String[] args) {
        SpringApplication.run(Main.class, args);
    }

    @GetMapping("/")
    public String getHelloWorld() {
        return "Hello World";
    }

    @PostMapping("/body")
    public String postHelloBody(@RequestBody Person person) {
        return "Hello " + person.getName();
    }
    @PostMapping("/header")
    public String postHelloHeader(@RequestHeader("Name") String name) {
        return "Hello " + name;
    }
    @PostMapping("/param")
    public String postHelloParam(@RequestParam("Name") String name) {
        return "Hello " + name;
    }
}