package ua.lnu.edu.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import ua.lnu.edu.model.Author;
import ua.lnu.edu.services.AuthorService;


import java.util.List;

@RestController
@RequestMapping("/authors")
public class AuthorController {

    private final AuthorService authorService;

    @Autowired
    public AuthorController(AuthorService authorService) {
        this.authorService = authorService;
    }

    @GetMapping
    public List<Author> getAllAuthors() {
        return authorService.findAll();
    }

    @GetMapping("/{id}")
    public Author getAuthorById(@PathVariable Long id) {
        return authorService.findById(id);
    }

    @GetMapping(params = "id")
    public Author getAuthorByIdParam(@RequestParam Long id) {
        return authorService.findById(id);
    }

    @GetMapping(headers = "id")
    public Author getAuthorByIdHeader(@RequestHeader Long id) {
        return authorService.findById(id);
    }

    @PostMapping
    public Author addAuthor(@RequestBody Author author) {
        return authorService.save(author);
    }

    @PostMapping(params = {"name", "nationality"})
    public Author addAuthorFromParams(@RequestParam String name, @RequestParam String nationality) {
        Author author = new Author();
        author.setName(name);
        author.setNationality(nationality);
        return authorService.save(author);
    }

    @PostMapping(headers = {"name", "nationality"})
    public Author addAuthorFromHeader(@RequestHeader("name") String name, @RequestHeader("nationality") String nationality) {
        Author author = new Author();
        author.setName(name);
        author.setNationality(nationality);
        return authorService.save(author);
    }

    @PutMapping("/{id}")
    public Author updateAuthor(@PathVariable Long id, @RequestBody Author authorDetails) {
        Author author = authorService.findById(id);

        author.setName(authorDetails.getName());
        author.setNationality(authorDetails.getNationality());

        return authorService.save(author);
    }

    @PutMapping(path = "/{id}", params = {"name", "nationality"})
    public Author updateAuthorFromParam(@PathVariable Long id,
                                        @RequestParam("name") String name,
                                        @RequestParam("nationality") String nationality) {
        Author author = authorService.findById(id);

        author.setName(name);
        author.setNationality(nationality);

        return authorService.save(author);
    }

    @PutMapping(path = "/{id}", headers = {"name", "nationality"})
    public Author updateAuthorFromHeader(@PathVariable Long id,
                                         @RequestHeader("name") String name,
                                         @RequestHeader("nationality") String nationality) {
        Author author = authorService.findById(id);

        author.setName(name);
        author.setNationality(nationality);

        return authorService.save(author);
    }

    @PatchMapping("/{id}")
    public Author patchAuthor(@PathVariable Long id, @RequestBody Author authorDetails) {
        Author author = authorService.findById(id);

        if (authorDetails.getName() != null) {
            author.setName(authorDetails.getName());
        }
        if (authorDetails.getNationality() != null) {
            author.setNationality(authorDetails.getNationality());
        }

        return authorService.save(author);
    }

    @PatchMapping(path = "/{id}", params = {"name", "nationality"})
    public Author patchAuthorFromParam(@PathVariable Long id,
                                       @RequestParam("name") String name,
                                       @RequestParam("nationality") String nationality) {
        Author author = authorService.findById(id);

        if (name != null) {
            author.setName(name);
        }
        if (nationality != null) {
            author.setNationality(nationality);
        }

        return authorService.save(author);
    }

    @PatchMapping(path = "/{id}", headers = {"name", "nationality"})
    public Author patchAuthorFromHeader(@PathVariable Long id,
                                        @RequestHeader("name") String name,
                                        @RequestHeader("nationality") String nationality) {
        Author author = authorService.findById(id);

        if (name != null) {
            author.setName(name);
        }

        if (nationality != null) {
            author.setNationality(nationality);
        }

        return authorService.save(author);
    }

    @DeleteMapping("/{id}")
    public void deleteAuthor(@PathVariable Long id) {
        Author author = authorService.findById(id);
        authorService.delete(author);
    }

    @DeleteMapping(params = "id")
    public void deleteAuthorFromParams(@RequestParam Long id) {
        Author author = authorService.findById(id);
        authorService.delete(author);
    }

    @DeleteMapping(headers = "id")
    public void deleteAuthorFromHeader(@RequestHeader Long id) {
        Author author = authorService.findById(id);
        authorService.delete(author);
    }
}
