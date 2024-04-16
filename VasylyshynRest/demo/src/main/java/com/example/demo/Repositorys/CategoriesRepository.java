package com.example.demo.Repositorys;

import com.example.demo.Entity.Categories;
import org.springframework.data.repository.CrudRepository;

public interface CategoriesRepository extends CrudRepository<Categories, Long> {
}
