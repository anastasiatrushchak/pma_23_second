package org.example.Predko;

import org.example.Predko.Class.Actor;
import org.example.Predko.Class.ActorMovie;
import org.example.Predko.Class.Movie;
import org.example.Predko.Exception.ResourceNotFoundException;
import org.example.Predko.Repository.ActorMovieRepository;
import org.example.Predko.Repository.ActorRepository;
import org.example.Predko.Repository.MovieRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/actor-movie")
public class ActorMovieController {

    @Autowired
    private ActorRepository actorRepository;

    @Autowired
    private MovieRepository movieRepository;

    @Autowired
    private ActorMovieRepository actorMovieRepository;

    @PostMapping("/actors")
    public Actor createActor(@RequestBody Actor actor) {
        return actorRepository.save(actor);
    }

    @PostMapping("/movies")
    public Movie createMovie(@RequestBody Movie movie) {
        return movieRepository.save(movie);
    }

    @PostMapping("")
    public ActorMovie createActorMovie(@RequestBody ActorMovie actorMovie) {
        return actorMovieRepository.save(actorMovie);
    }

    @GetMapping("/actors")
    public List<Actor> getAllActors() {
        return actorRepository.findAll();
    }

    @GetMapping("/movies")
    public List<Movie> getAllMovies() {
        return movieRepository.findAll();
    }

    @GetMapping("")
    public List<ActorMovie> getAllActorMovies() {
        return actorMovieRepository.findAll();
    }

    @GetMapping("/actors/{id}")
    public Optional<Actor> getActorById(@PathVariable Long id) {
        return actorRepository.findById(id);
    }

    @GetMapping("/movies/{id}")
    public Optional<Movie> getMovieById(@PathVariable Long id) {
        return movieRepository.findById(id);
    }

    @GetMapping("/{id}")
    public Optional<ActorMovie> getActorMovieById(@PathVariable Long id) {
        return actorMovieRepository.findById(id);
    }

    @PutMapping("/actors/{id}")
    public Actor updateActor(@PathVariable Long id, @RequestBody Actor actorDetails) {
        Actor actor = actorRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Actor not found with id: " + id));

        actor.setName(actorDetails.getName());
        actor.setAge(actorDetails.getAge());

        return actorRepository.save(actor);
    }

    @PutMapping("/movies/{id}")
    public Movie updateMovie(@PathVariable Long id, @RequestBody Movie movieDetails) {
        Movie movie = movieRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Movie not found with id: " + id));

        movie.setTitle(movieDetails.getTitle());
        movie.setRating(movieDetails.getRating());

        return movieRepository.save(movie);
    }

    @PatchMapping("/actors/{id}")
    public Actor patchActor(@PathVariable Long id, @RequestBody Actor actorDetails) {
        Actor actor = actorRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Actor not found with id: " + id));

        if (actorDetails.getName() != null) {
            actor.setName(actorDetails.getName());
        }
        if (actorDetails.getAge() != 0) {
            actor.setAge(actorDetails.getAge());
        }

        return actorRepository.save(actor);
    }

    @PatchMapping("/movies/{id}")
    public Movie patchMovie(@PathVariable Long id, @RequestBody Movie movieDetails) {
        Movie movie = movieRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Movie not found with id: " + id));

        if (movieDetails.getTitle() != null) {
            movie.setTitle(movieDetails.getTitle());
        }
        if (movieDetails.getRating() != 0) {
            movie.setRating(movieDetails.getRating());
        }

        return movieRepository.save(movie);
    }


    @DeleteMapping("/actors/{id}")
    public ResponseEntity<?> deleteActor(@PathVariable Long id) {
        return actorRepository.findById(id)
                .map(actor -> {
                    actorRepository.delete(actor);
                    return ResponseEntity.ok().build();
                }).orElseThrow(() -> new ResourceNotFoundException("Actor not found with id: " + id));
    }

    @DeleteMapping("/movies/{id}")
    public ResponseEntity<?> deleteMovie(@PathVariable Long id) {
        return movieRepository.findById(id)
                .map(movie -> {
                    movieRepository.delete(movie);
                    return ResponseEntity.ok().build();
                }).orElseThrow(() -> new ResourceNotFoundException("Movie not found with id: " + id));
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteActorMovie(@PathVariable Long id) {
        return actorMovieRepository.findById(id)
                .map(actorMovie -> {
                    actorMovieRepository.delete(actorMovie);
                    return ResponseEntity.ok().build();
                }).orElseThrow(() -> new ResourceNotFoundException("Actor-Movie relation not found with id: " + id));
    }
}
