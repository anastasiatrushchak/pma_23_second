package com.example.demo.Repositorys;

import com.example.demo.Entity.Posts;
import org.springframework.data.repository.CrudRepository;

import java.nio.file.LinkOption;

public interface PostsRepository extends CrudRepository<Posts, Long> {
}
