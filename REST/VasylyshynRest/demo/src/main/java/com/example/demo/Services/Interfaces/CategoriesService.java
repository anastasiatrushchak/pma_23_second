package com.example.demo.Services.Interfaces;

import com.example.demo.Entity.Categories;

public interface CategoriesService {
    Categories SaveCategory(Categories categories);
    void DeleteCategory(Long Id);
    Iterable<Categories> FindAllCategory();

}
