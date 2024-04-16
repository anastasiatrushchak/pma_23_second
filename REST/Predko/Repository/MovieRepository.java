package org.example.Predko.Repository;

import org.example.Predko.Class.Movie;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MovieRepository extends JpaRepository<Movie, Long> {
}
