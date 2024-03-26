package org.ya.mozil;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@SpringBootApplication
@RestController
public class TestRest {

    static class Request {
        private String name;

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }
    }


    @GetMapping("/helloworld")
    public String getHelloWorld() {
        return "HelloWorld!";
    }

    @PostMapping("/helloworld")
    public String postHello() {
        return "HelloWorld!";
    }

    @PostMapping("/helloworld/param")
    public String postHelloByParam(@RequestParam (name = "name", required = false) String paramName){
        return "hello" + paramName;
    }
    @PostMapping("/helloworld/header")
    public String postHelloByHeader(@RequestHeader(name = "name", required = false) String headerName){
        return "hello" + headerName;
    }

    @PostMapping("/helloworld/body")
    public String postHelloByBody(@RequestBody(required = false) Request requestBody){
        Optional<Request> optionalRequest = Optional.ofNullable(requestBody);
        String name = optionalRequest.map(Request::getName).orElse("");
        return "hello " + name;
    }


    public static void main(String[] args) {
        SpringApplication.run(TestRest.class, args);
    }
}