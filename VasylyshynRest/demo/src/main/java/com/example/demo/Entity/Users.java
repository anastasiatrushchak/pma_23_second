package com.example.demo.Entity;

import com.example.demo.Enums.Gender;
import jakarta.persistence.*;

import java.time.LocalDate;


@Entity
@Table(name = "Users")
public class Users {
    @Id
    @GeneratedValue(strategy=GenerationType.AUTO)
    private Long UserId;
    @Column(name="Name", length=30, nullable=false)
    private String Name;
    @Column(name="Email", length=50, nullable=false, unique = true)
    private String Email;
    @Column(name="DataOfBirth", nullable=false)
    private LocalDate DataOfBirth;
    private LocalDate CreatedAt;
    //@Transient
    private int Age;
    @Enumerated(EnumType.STRING)
    private Gender Gender;
    @Lob
    @Column(name = "ImageDataUser", length = 1000)
    private byte[] ImageDataUsers;

    public Users(Long userId, String name, String email, LocalDate dataOfBirth, LocalDate createdAt, int age, Gender gender, byte[] imageDataUsers) {
        UserId = userId;
        Name = name;
        Email = email;
        DataOfBirth = dataOfBirth;
        CreatedAt = createdAt;
        Age = age;
        Gender = gender;
        ImageDataUsers = imageDataUsers;
    }

    public Users() {
    }

    public Long getUserId() {
        return UserId;
    }

    public void setUserId(Long userId) {
        UserId = userId;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }

    public LocalDate getDataOfBirth() {
        return DataOfBirth;
    }

    public void setDataOfBirth(LocalDate dataOfBirth) {
        DataOfBirth = dataOfBirth;
    }

    public LocalDate getCreatedAt() {
        return CreatedAt;
    }

    public void setCreatedAt(LocalDate createdAt) {
        CreatedAt = createdAt;
    }

    public int getAge() {
        return Age;
    }

    public void setAge(int age) {
        Age = age;
    }

    public com.example.demo.Enums.Gender getGender() {
        return Gender;
    }

    public void setGender(com.example.demo.Enums.Gender gender) {
        Gender = gender;
    }

    public byte[] getImageDataUsers() {
        return ImageDataUsers;
    }

    public void setImageDataUsers(byte[] imageDataUsers) {
        ImageDataUsers = imageDataUsers;
    }
}
