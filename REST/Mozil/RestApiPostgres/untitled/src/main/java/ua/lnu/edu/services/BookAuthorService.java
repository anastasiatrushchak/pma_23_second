package ua.lnu.edu.services;

import lombok.AllArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import ua.lnu.edu.exceptions.ResourceNotFoundException;
import ua.lnu.edu.model.Author;
import ua.lnu.edu.model.Book;
import ua.lnu.edu.model.BookAuthor;
import ua.lnu.edu.repositories.AuthorRepository;
import ua.lnu.edu.repositories.BookAuthorRepository;
import ua.lnu.edu.repositories.BookRepository;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
public class BookAuthorService {

    private final BookRepository bookRepository;
    private final BookAuthorRepository bookAuthorRepository;
    private final AuthorRepository authorRepository;

    @Autowired
    public BookAuthorService(BookRepository bookRepository, BookAuthorRepository bookAuthorRepository, AuthorRepository authorRepository) {
        this.bookRepository = bookRepository;
        this.bookAuthorRepository = bookAuthorRepository;
        this.authorRepository = authorRepository;
    }

    public Book saveBook(Book book) {
        return bookRepository.save(book);
    }

    public BookAuthor saveBookAuthor(BookAuthor bookAuthor) {
        return bookAuthorRepository.save(bookAuthor);
    }

    public Author saveAuthor(Author author) {
        return authorRepository.save(author);
    }

    public Book getBookById(Long id) {
        return bookRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Book not found with id " + id));
    }

    public BookAuthor getBookAuthorById(Long id) {
        return bookAuthorRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("BookAuthor not found with id " + id));
    }

    public Author getAuthorById(Long id) {
        return authorRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Author not found with id " + id));
    }

    public List<Book> getAllBooks() {
        return bookRepository.findAll();
    }

    public List<BookAuthor> getAllBookAuthors() {
        return bookAuthorRepository.findAll();
    }

    public List<Author> getAllAuthors() {
        return authorRepository.findAll();
    }

    public void deleteBook(Long id) {
        bookRepository.deleteById(id);
    }

    public void deleteBookAuthor(Long id) {
        bookAuthorRepository.deleteById(id);
    }

    public void deleteAuthor(Long id) {
        authorRepository.deleteById(id);
    }

    public List<BookAuthor> findAll() {
        return bookAuthorRepository.findAll();
    }

    public BookAuthor findById(Long id) {
        return bookAuthorRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("BookAuthor not found with id " + id));
    }

    public BookAuthor save(BookAuthor bookAuthor) {
        return bookAuthorRepository.save(bookAuthor);
    }

    public void delete(BookAuthor bookAuthor) {
        bookAuthorRepository.delete(bookAuthor);
    }

    public BookAuthor findByBookIdAndAuthorId(Long bookId, Long authorId) {
        return bookAuthorRepository.findByBookIdAndAuthorId(bookId, authorId)
                .orElseThrow(() -> new ResourceNotFoundException("BookAuthor not found with bookId " + bookId + " and authorId " + authorId));
    }

    public List<Author> findAuthorsByBookId(Long bookId) {
        List<BookAuthor> bookAuthors = bookAuthorRepository.findBookAuthorsByBookId(bookId);
        List<Author> authors = new ArrayList<>();
        for (BookAuthor bookAuthor : bookAuthors) {
            authors.add(bookAuthor.getAuthor());
        }
        return authors;
    }

    public List<Book> findBooksByAuthorId(Long authorId) {
        List<BookAuthor> bookAuthors = bookAuthorRepository.findBookAuthorsByAuthorId(authorId);
        List<Book> books = new ArrayList<>();
        for (BookAuthor bookAuthor : bookAuthors) {
            books.add(bookAuthor.getBook());
        }
        return books;
    }

    public void deleteById(Long id) {
        bookAuthorRepository.deleteById(id);
    }
}
