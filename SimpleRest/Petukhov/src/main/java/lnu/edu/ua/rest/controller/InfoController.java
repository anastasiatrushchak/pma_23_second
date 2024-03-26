package lnu.edu.ua.rest.controller;

import jakarta.validation.Valid;
import lnu.edu.ua.rest.exception.InvalidKeyException;
import lnu.edu.ua.rest.model.TextBody;
import lombok.RequiredArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

@RequiredArgsConstructor
@RestController
@RequestMapping("/")
public class InfoController {
    @GetMapping
    public String getAll() {
        return "Hello World";
    }

    @PostMapping("/header")
    @ResponseStatus(HttpStatus.CREATED)
    public String handlePostWithHeader(@RequestHeader(value = "text", required = false) String headerValue) {
        validateHeaderValue(headerValue);
        return buildResponse(headerValue);
    }

    @PostMapping("/param")
    @ResponseStatus(HttpStatus.CREATED)
    public String handlePostWithParam(@RequestParam(value = "text", required = false) String paramValue) {
        validateParamValue(paramValue);
        return buildResponse(paramValue);
    }

    @PostMapping("/body")
    @ResponseStatus(HttpStatus.CREATED)
    public String handlePostWithBody(@Valid @RequestBody(required = false) TextBody textBody) {
        validateTextBody(textBody);
        return buildResponse(textBody.getText());
    }

    private void validateHeaderValue(String headerValue) {
        if (headerValue != null && !(headerValue instanceof String)) {
            throw new InvalidKeyException("Invalid header key. Expected a string.");
        }
    }

    private void validateParamValue(String paramValue) {
        if (paramValue != null && !(paramValue instanceof String)) {
            throw new InvalidKeyException("Invalid param key. Expected a string.");
        }
    }

    private void validateTextBody(TextBody textBody) {
        if (textBody != null && !(textBody.getText() instanceof String)) {
            throw new InvalidKeyException("Invalid body key. Expected a string.");
        }
    }

    private String buildResponse(String value) {
        String response = "Hello from ";
        if (value != null) {
            response += value;
        }
        return response;
    }

}