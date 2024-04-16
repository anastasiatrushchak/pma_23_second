package ua.lnu.edu.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.web.bind.annotation.*;
import ua.lnu.edu.exceptions.ResourceNotFoundException;
import ua.lnu.edu.model.Book;
import ua.lnu.edu.repositories.BookRepository;
import ua.lnu.edu.services.BookService;


import java.time.LocalDate;
import java.time.ZoneId;
import java.util.Date;
import java.util.List;


@RestController
@RequestMapping("/books")
public class BookController {


    private final BookService bookService;

    @Autowired
    public BookController(BookService bookService) {
        this.bookService = bookService;
    }

    @GetMapping
    public List<Book> getAllBooks() {
        return bookService.findAll();
    }

    @GetMapping("/{id}")
    public Book getBookById(@PathVariable Long id) {
        return bookService.findById(id);
    }

    @GetMapping(params = "id")
    public Book getBookByIdParam(@RequestParam Long id) {
        return bookService.findById(id);
    }

    @GetMapping(headers = "id")
    public Book getBookByIdHeader(@RequestHeader Long id) {
        return bookService.findById(id);
    }

    @PostMapping
    public Book addBook(@RequestBody Book book) {
        return bookService.save(book);
    }

    @PostMapping(params = {"title", "genre", "publicationDate", "isbn"})
    public Book addBookFromParams(@RequestParam String title,
                                  @RequestParam String genre,
                                  @RequestParam @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                  @RequestParam String isbn) {
        Book book = new Book();
        book.setTitle(title);
        book.setGenre(genre);
        book.setPublicationDate(Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()));
        book.setIsbn(isbn);
        return bookService.save(book);
    }

    @PostMapping(headers = {"title", "genre", "publicationDate", "isbn"})
    public Book addBookFromHeader(@RequestHeader("title") String title,
                                  @RequestHeader("genre") String genre,
                                  @RequestHeader("publicationDate") @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                  @RequestHeader("isbn") String isbn) {
        Book book = new Book();
        book.setTitle(title);
        book.setGenre(genre);
        book.setPublicationDate(Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()));
        book.setIsbn(isbn);
        return bookService.save(book);
    }


    @PutMapping("/{id}")
    public Book updateBook(@PathVariable Long id, @RequestBody Book bookDetails) {
        Book book = bookService.findById(id);

        book.setTitle(bookDetails.getTitle());
        book.setGenre(bookDetails.getGenre());
        book.setPublicationDate(bookDetails.getPublicationDate());
        book.setIsbn(bookDetails.getIsbn());

        return bookService.save(book);
    }

    @PutMapping(path = "/{id}", params = {"title", "genre", "publicationDate", "isbn"})
    public Book updateBookFromParam(@PathVariable Long id,
                                    @RequestParam("title") String title,
                                    @RequestParam("genre") String genre,
                                    @RequestParam("publicationDate") @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                    @RequestParam("isbn") String isbn) {
        Book book = bookService.findById(id);

        book.setTitle(title);
        book.setGenre(genre);
        book.setPublicationDate(Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()));
        book.setIsbn(isbn);

        return bookService.save(book);
    }

    @PutMapping(path = "/{id}", headers = {"title", "genre", "publicationDate", "isbn"})
    public Book updateBookFromHeader(@PathVariable Long id,
                                     @RequestHeader("title") String title,
                                     @RequestHeader("genre") String genre,
                                     @RequestHeader("publicationDate") @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                     @RequestHeader("isbn") String isbn) {
        Book book = bookService.findById(id);

        book.setTitle(title);
        book.setGenre(genre);
        book.setPublicationDate(publicationDate != null ? Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()) : null);
        book.setIsbn(isbn);

        return bookService.save(book);
    }

    @PatchMapping("/{id}")
    public Book patchBook(@PathVariable Long id, @RequestBody Book bookDetails) {
        Book book = bookService.findById(id);

        if (bookDetails.getTitle() != null) {
            book.setTitle(bookDetails.getTitle());
        }
        if (bookDetails.getGenre() != null) {
            book.setGenre(bookDetails.getGenre());
        }
        if (bookDetails.getPublicationDate() != null) {
            book.setPublicationDate(bookDetails.getPublicationDate());
        }
        if (bookDetails.getIsbn() != null) {
            book.setIsbn(bookDetails.getIsbn());
        }

        return bookService.save(book);
    }

    @PatchMapping(path = "/{id}", params = {"title", "genre", "publicationDate", "isbn"})
    public Book patchBookFromParam(@PathVariable Long id,
                                    @RequestParam(required = false) String title,
                                    @RequestParam(required = false) String genre,
                                    @RequestParam(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                    @RequestParam(required = false) String isbn) {
        Book book = bookService.findById(id);

        if (title != null) {
            book.setTitle(title);
        }
        if (genre != null) {
            book.setGenre(genre);
        }
        if (publicationDate != null) {
            book.setPublicationDate(Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()));
        }
        if (isbn != null) {
            book.setIsbn(isbn);
        }

        return bookService.save(book);
    }

    @PatchMapping(path = "/{id}", headers = {"title", "genre", "publicationDate", "isbn"})
    public Book patchBookFromHeader(@PathVariable Long id,
                                     @RequestHeader(required = false) String title,
                                     @RequestHeader(required = false) String genre,
                                     @RequestHeader(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                     @RequestHeader(required = false) String isbn) {
        Book book = bookService.findById(id);

        if (title != null) {
            book.setTitle(title);
        }
        if (genre != null) {
            book.setGenre(genre);
        }
        if (publicationDate != null) {
            book.setPublicationDate(Date.from(publicationDate.atStartOfDay(ZoneId.systemDefault()).toInstant()));
        }
        if (isbn != null) {
            book.setIsbn(isbn);
        }

        return bookService.save(book);
    }

    @DeleteMapping("/{id}")
    public void deleteBook(@PathVariable Long id) {
        Book book = bookService.findById(id);
        bookService.delete(book);
    }

    @DeleteMapping(params = "id")
    public void deleteBookFromParams(@RequestParam Long id) {
        Book book = bookService.findById(id);
        bookService.delete(book);
    }

    @DeleteMapping(headers = "id")
    public void deleteBookFromHeader(@RequestHeader Long id) {
        Book book = bookService.findById(id);
        bookService.delete(book);
    }


}
