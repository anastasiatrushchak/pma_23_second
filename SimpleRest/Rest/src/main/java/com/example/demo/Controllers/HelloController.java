package com.example.demo.Controllers;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
public class HelloController {

    @PostMapping("/hello")
    public ResponseEntity<String> helloPost(@RequestHeader(value = "name", required = false) String Name, @RequestBody(required = false) String Body, @RequestParam(value = "name", required = false) String NameParameter) {
        if (Name != null) {
            return ResponseEntity.ok("Привіт, чуваче переданий сюди хедером " + Name);
        } else if (Body != null) {
            return ResponseEntity.ok("Привіт, чуваче з боді " + Body);
        } else if (NameParameter!=null){
            return ResponseEntity.ok("Привіт чуваче поданий сюди параметром "+ NameParameter);
        }else {
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Не вказано ім'я або тіло запиту");
        }
    }
    @GetMapping("/hello")
    public String hello() {
        return "Привіт";
    }
}

