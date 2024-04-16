package ua.lnu.edu.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import ua.lnu.edu.model.Author;
import ua.lnu.edu.model.Book;
import ua.lnu.edu.model.BookAuthor;

import java.util.List;
import java.util.Optional;

public interface BookAuthorRepository extends JpaRepository<BookAuthor, Long> {
    Optional<BookAuthor> findByBookIdAndAuthorId(Long bookId, Long authorId);

    List<Author> findAuthorsByBookId(Long bookId);

    List<Book> findBooksByAuthorId(Long authorId);

    List<BookAuthor> findBookAuthorsByBookId(Long bookId);

    List<BookAuthor> findBookAuthorsByAuthorId(Long authorId);
}
