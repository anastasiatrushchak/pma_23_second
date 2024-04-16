package com.example.demo.Controllers;

import com.example.demo.Entity.Categories;
import com.example.demo.Services.Interfaces.CategoriesService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/categories")
public class CategoriesController {
    @Autowired
    private CategoriesService categoriesService;
    @PostMapping
    public Categories SaveCategory(@Validated @RequestBody Categories categories){
        return categoriesService.SaveCategory(categories);
    }
    @GetMapping
    public Object GetCategory(){
        return categoriesService.FindAllCategory();
    }
    @DeleteMapping
    public String DeleteCategory(@RequestParam Long Id){
        categoriesService.DeleteCategory(Id);
        return "deleted with id "+Id;
    }

}
