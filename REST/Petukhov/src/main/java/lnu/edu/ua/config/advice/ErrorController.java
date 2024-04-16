package lnu.edu.ua.config.advice;

import jakarta.validation.ConstraintViolationException;
import jakarta.validation.ValidationException;
import lnu.edu.ua.exception.AgreementNotFoundException;
import lnu.edu.ua.exception.CarNotFoundException;
import lnu.edu.ua.exception.CustomerNotFoundException;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestControllerAdvice;

@RestControllerAdvice
public class ErrorController {
    @ExceptionHandler(
            CarNotFoundException.class
    )
    @ResponseStatus(HttpStatus.NOT_FOUND)
    ErrorDto handleProductNotFoundException(Exception ex) {
        return new ErrorDto(ex.getMessage());
    }

    @ExceptionHandler(
            CustomerNotFoundException.class
    )
    @ResponseStatus(HttpStatus.NOT_FOUND)
    ErrorDto handleCustomerNotFoundException(Exception ex) {
        return new ErrorDto(ex.getMessage());
    }

    @ExceptionHandler(
            AgreementNotFoundException.class
    )
    @ResponseStatus(HttpStatus.NOT_FOUND)
    ErrorDto handleAgreementNotFoundException(Exception ex) {
        return new ErrorDto(ex.getMessage());
    }

    @ExceptionHandler({
            ValidationException.class,
            MethodArgumentNotValidException.class,
            ConstraintViolationException.class
    })
    @ResponseStatus(HttpStatus.BAD_REQUEST)
    ErrorDto handleValidationException() {
        return new ErrorDto("Invalid data format");
    }

    @ExceptionHandler(
            DataIntegrityViolationException.class
    )
    @ResponseStatus(HttpStatus.FORBIDDEN)
    ErrorDto handleDataIntegrityViolationException() {
        return new ErrorDto("Invalid operation on data. Review your request.");
    }

    record ErrorDto(String error) {
    }
}