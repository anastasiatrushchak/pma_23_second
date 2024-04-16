package ua.lnu.edu.controllers;

import lombok.Getter;
import lombok.Setter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.web.bind.annotation.*;
import ua.lnu.edu.model.Author;
import ua.lnu.edu.model.Book;
import ua.lnu.edu.model.BookAuthor;
import ua.lnu.edu.services.AuthorService;
import ua.lnu.edu.services.BookAuthorService;
import ua.lnu.edu.services.BookService;

import java.time.LocalDate;
import java.util.List;

import static java.sql.Date.*;

@RestController
@RequestMapping("/book-authors")
public class BookAuthorController {

    private final BookAuthorService bookAuthorService;
    private final BookService bookService;
    private final AuthorService authorService;

    @Autowired
    public BookAuthorController(BookAuthorService bookAuthorService, BookService bookService, AuthorService authorService) {
        this.bookAuthorService = bookAuthorService;
        this.bookService = bookService;
        this.authorService = authorService;
    }

    @GetMapping
    public List<BookAuthor> getAllBookAuthors() {
        return bookAuthorService.findAll();
    }

    @GetMapping("/{id}")
    public BookAuthor getBookAuthorById(@PathVariable Long id) {
        return bookAuthorService.findById(id);
    }

    @GetMapping(params = "id")
    public BookAuthor getBookAuthorByIdParam(@RequestParam Long id) {
        return bookAuthorService.findById(id);
    }

    @GetMapping(headers = "id")
    public BookAuthor getBookAuthorByIdHeader(@RequestHeader Long id) {
        return bookAuthorService.findById(id);
    }

    @GetMapping("/books")
    public List<Book> getAllBooks(){return bookService.findAll();}

    @GetMapping("/authors")
    public List<Author> getAllAuthors(){return authorService.findAll();}

    //знайти автора книги по id книги та id автора через параметри
    @GetMapping(params = {"bookId", "authorId"})
    public BookAuthor getBookAuthorByBookIdAndAuthorId(@RequestParam Long bookId, @RequestParam Long authorId) {
        return bookAuthorService.findByBookIdAndAuthorId(bookId, authorId);
    }

    //знайти автора по id книги
    @GetMapping("/book/{bookId}")
    public List<Author> getAuthorsByBookId(@PathVariable Long bookId) {
        return bookAuthorService.findAuthorsByBookId(bookId);
    }


    //знайти книги по id автора
    @GetMapping("/author/{authorId}")
    public List<Book> getBooksByAuthorId(@PathVariable Long authorId) {
        return bookAuthorService.findBooksByAuthorId(authorId);
    }

    //додати книжку за id книги та id автора через параметри
    @PostMapping(params = {"bookId", "authorId"})
    public BookAuthor addBookAuthor(@RequestParam Long bookId, @RequestParam Long authorId) {
        Book book = bookService.findById(bookId);
        Author author = authorService.findById(authorId);

        BookAuthor bookAuthor = new BookAuthor();
        bookAuthor.setBook(book);
        bookAuthor.setAuthor(author);

        return bookAuthorService.save(bookAuthor);
    }

    // додати автора та книжку за інформацією з параметрів
    @PostMapping(params = {"title", "genre", "publicationDate", "isbn", "name", "nationality"})
    public BookAuthor addBookAuthorWithBookFromParams(@RequestParam String title,
                                                      @RequestParam(required = false) String genre,
                                                      @RequestParam(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                                      @RequestParam String isbn,
                                                      @RequestParam String name,
                                                      @RequestParam(required = false) String nationality) {
        if (title == null || isbn == null || name == null) {
            throw new IllegalArgumentException("Title, ISBN and Name are required");
        } else {
            if (genre == null || genre.isEmpty()) genre = "Unknown";
            if (publicationDate == null) publicationDate = LocalDate.now();
            if (nationality == null || nationality.isEmpty()) nationality = "Unknown";

            Book book = new Book();
            book.setTitle(title);
            book.setGenre(genre);
            book.setPublicationDate(java.sql.Date.valueOf(publicationDate));
            book.setIsbn(isbn);
            book = bookService.save(book);

            Author author = new Author();
            author.setName(name);
            author.setNationality(nationality);
            author = authorService.save(author);

            BookAuthor bookAuthor = new BookAuthor();
            bookAuthor.setBook(book);
            bookAuthor.setAuthor(author);

            return bookAuthorService.save(bookAuthor);
        }
    }

    @PostMapping(params = {"title", "genre", "publicationDate", "isbn"}, path = "/book")
    public Book addBookAuthorWithBookParams(@RequestParam String title,
                                            @RequestParam(required = false) String genre,
                                            @RequestParam(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                            @RequestParam String isbn) {
        if (title == null || isbn == null) {
            throw new IllegalArgumentException("Title, ISBN and Name are required");
        } else {
            if (genre == null) genre = "Unknown";
            if (publicationDate == null) publicationDate = LocalDate.now();

            Book book = new Book();
            book.setTitle(title);
            book.setGenre(genre);
            book.setPublicationDate(valueOf(publicationDate));
            book.setIsbn(isbn);

            return bookService.save(book);
        }
    }

    //додати автора за параметрами
    @PostMapping(params = {"name", "nationality"}, path = "/author")
    public Author addBookAuthorWithAuthorParams(@RequestParam String name,
                                                @RequestParam(required = false) String nationality) {
        if (name == null) {
            throw new IllegalArgumentException("Name is required");
        } else {
            if (nationality == null) nationality = "Unknown";

            Author author = new Author();
            author.setName(name);
            author.setNationality(nationality);
            authorService.save(author);

            return authorService.save(author);

        }
    }

    //змінф автора книги через айді книги та автора в хедері
    @PatchMapping(path = "/{id}", headers = {"bookId", "authorId"})
    public BookAuthor patchBookAuthorFromHeader(@PathVariable Long id,
                                                @RequestHeader Long bookId,
                                                @RequestHeader Long authorId) {
        BookAuthor bookAuthor = bookAuthorService.findById(id);
        Book book = bookService.findById(bookId);
        Author author = authorService.findById(authorId);

        bookAuthor.setBook(book);
        bookAuthor.setAuthor(author);

        return bookAuthorService.save(bookAuthor);
    }

    //зміна автора книги параметрами через хедер
    @PatchMapping(path = "/{id}", headers = {"title", "genre", "publicationDate", "isbn", "name", "nationality"})
    public BookAuthor patchBookAuthorFromParams(@PathVariable Long id,
                                                @RequestHeader String title,
                                                @RequestHeader(required = false) String genre,
                                                @RequestHeader(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                                @RequestHeader String isbn,
                                                @RequestHeader String name,
                                                @RequestHeader(required = false) String nationality) {
        BookAuthor bookAuthor = bookAuthorService.findById(id);
        Book book = bookAuthor.getBook();
        Author author = bookAuthor.getAuthor();

        if (title != null) book.setTitle(title);
        if (genre != null) book.setGenre(genre);
        if (publicationDate != null) book.setPublicationDate(valueOf(publicationDate));
        if (isbn != null) book.setIsbn(isbn);
        if (name != null) author.setName(name);
        if (nationality != null) author.setNationality(nationality);

        book = bookService.save(book);
        author = authorService.save(author);

        bookAuthor.setBook(book);
        bookAuthor.setAuthor(author);

        return bookAuthorService.save(bookAuthor);
    }

    //змінф книгу через хедер
    @PatchMapping(path = "/book/{id}", headers = {"title", "genre", "publicationDate", "isbn"})
    public Book patchBookFromHeader(@PathVariable Long id,
                                    @RequestHeader(required = false) String title,
                                    @RequestHeader(required = false) String genre,
                                    @RequestHeader(required = false) @DateTimeFormat(iso = DateTimeFormat.ISO.DATE) LocalDate publicationDate,
                                    @RequestHeader(required = false) String isbn) {
        Book book = bookService.findById(id);

        if (title != null) book.setTitle(title);
        if (genre != null) book.setGenre(genre);
        if (publicationDate != null) book.setPublicationDate(valueOf(publicationDate));
        if (isbn != null) book.setIsbn(isbn);

        return bookService.update(id, book);
    }

    //зміна автора через хедер
    @PatchMapping(path = "/author/{id}", headers = {"name", "nationality"})
    public Author patchAuthorFromHeader(@PathVariable Long id,
                                        @RequestHeader(required = false) String name,
                                        @RequestHeader(required = false) String nationality) {
        Author author = authorService.findById(id);

        if (name != null) author.setName(name);
        if (nationality != null) author.setNationality(nationality);

        return authorService.update(id, author);
    }

    //видалення за допомогою тіла запиту
    @DeleteMapping
    public void deleteBookAuthor(@RequestBody IdWrapper idWrapper) {
        bookAuthorService.deleteById(idWrapper.getId());
    }

    @DeleteMapping("/book")
    public void deleteBook(@RequestBody IdWrapper idWrapper) {
        bookService.deleteBookById(idWrapper.getId());
    }

    @DeleteMapping("/author")
    public void deleteAuthor(@RequestBody IdWrapper idWrapper) {
        authorService.deleteAuthorById(idWrapper.getId());
    }

    @Setter
    @Getter
    public static class IdWrapper {
        private Long id;
    }
}
