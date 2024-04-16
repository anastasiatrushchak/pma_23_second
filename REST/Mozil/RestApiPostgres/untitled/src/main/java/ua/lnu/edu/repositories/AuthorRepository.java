package ua.lnu.edu.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ua.lnu.edu.model.Author;

@Repository
public interface AuthorRepository extends JpaRepository<Author, Long> {
}
