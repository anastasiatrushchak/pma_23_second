package ua.lnu.edu.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ua.lnu.edu.model.Book;

@Repository
public interface BookRepository extends JpaRepository<Book, Long> {
}

