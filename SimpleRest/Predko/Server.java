package org.example.Predko;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.*;

@SpringBootApplication
@RestController
public class Server {

    public static void main(String[] args) {
        SpringApplication.run(Server.class, args);
    }

    @GetMapping("/hello")
    public String getHelloWorld() {
        return "Hello World";
    }

    @PostMapping("/body")
    public String postBody(@RequestBody JsonRequest request) {
        return "Hello from JSON in body: " + request.getName();
    }

    @PostMapping("/param")
    public String postParam(@RequestParam("name") String name) {
        return "Hello from parameter: " + name;
    }

    @PostMapping("/header")
    public String postHeader(@RequestHeader("name") String name) {
        return "Hello from header: " + name;
    }

    static class JsonRequest {
        private String name;

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }
    }
}

