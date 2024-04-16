package com.example.demo.Entity;

import jakarta.persistence.*;

@Entity
@Table(name = "Categories")
public class Categories {

    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private Long CategoryId;
    @Column(name="CategoryName", length=40, nullable=false, unique = true)
    private String CategoryName;

    public Categories(Long categoryId, String categoryName) {
        CategoryId = categoryId;
        CategoryName = categoryName;
    }

    public Categories() {
    }

    public Long getCategoryId() {
        return CategoryId;
    }

    public void setCategoryId(Long categoryId) {
        CategoryId = categoryId;
    }

    public String getCategoryName() {
        return CategoryName;
    }

    public void setCategoryName(String categoryName) {
        CategoryName = categoryName;
    }
}
