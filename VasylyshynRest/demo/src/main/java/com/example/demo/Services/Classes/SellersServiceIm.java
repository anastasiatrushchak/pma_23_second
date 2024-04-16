package com.example.demo.Services.Classes;

import com.example.demo.Entity.Sellers;
import com.example.demo.Entity.Users;
import com.example.demo.Repositorys.SellersRepository;
import com.example.demo.Repositorys.UsersRepository;
import com.example.demo.Services.Interfaces.SellersService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Optional;
@Service
public class SellersServiceIm implements SellersService {
    @Autowired
    private SellersRepository sellersRepository;
    @Autowired
    private UsersRepository usersRepository;
    @Override
    public Sellers SaveSeller(Sellers sellers) {
        Users users=usersRepository.findById(sellers.getUsers().getUserId()).orElse(null);
        sellers.setUsers(users);
        return sellersRepository.save(sellers);
    }

    @Override
    public void DeleteSeller(Long Id) {
        sellersRepository.deleteById(Id);
    }

    @Override
    public Optional<Sellers> FindByIdSeller(Long Id) {
        return sellersRepository.findById(Id);
    }

    @Override
    public Iterable<Sellers> FindAllSellers() {
        return sellersRepository.findAll();
    }
}
