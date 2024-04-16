package com.example.demo.Services.Classes;

import com.example.demo.Entity.Categories;
import com.example.demo.Repositorys.CategoriesRepository;
import com.example.demo.Services.Interfaces.CategoriesService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CategoriesServiceIm implements CategoriesService {
    @Autowired
    private CategoriesRepository categoriesRepository;
    @Override
    public Categories SaveCategory(Categories categories) {
        return categoriesRepository.save(categories);
    }

    @Override
    public void DeleteCategory(Long Id) {
        categoriesRepository.deleteById(Id);

    }

    @Override
    public Iterable<Categories> FindAllCategory() {
        return categoriesRepository.findAll();
    }
}
