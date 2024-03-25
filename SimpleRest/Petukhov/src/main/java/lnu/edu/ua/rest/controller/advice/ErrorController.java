package lnu.edu.ua.rest.controller.advice;

import jakarta.validation.ConstraintViolationException;
import jakarta.validation.ValidationException;
import lnu.edu.ua.rest.exception.InvalidKeyException;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestControllerAdvice;

@RestControllerAdvice
public class ErrorController {
    @ExceptionHandler(
            InvalidKeyException.class
    )
    @ResponseStatus(HttpStatus.NOT_FOUND)
    ErrorDto handleProductNotFoundException(Exception ex) {
        return new ErrorDto(ex.getMessage());
    }

    @ExceptionHandler({
            ValidationException.class,
            MethodArgumentNotValidException.class,
            ConstraintViolationException.class
    })
    @ResponseStatus(HttpStatus.INTERNAL_SERVER_ERROR)
    ErrorDto handleValidationException() {
        return new ErrorDto("Invalid data format");
    }

    record ErrorDto(String error) {}
}