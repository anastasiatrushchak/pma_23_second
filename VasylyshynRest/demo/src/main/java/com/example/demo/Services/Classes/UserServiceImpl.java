package com.example.demo.Services.Classes;

import com.example.demo.Entity.Users;
import com.example.demo.Repositorys.SellersRepository;
import com.example.demo.Repositorys.UsersRepository;
import com.example.demo.Services.Interfaces.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.time.Period;
import java.util.List;
import java.util.Objects;
import java.util.Optional;

@Service
public class UserServiceImpl implements UserService {
    @Autowired
    private UsersRepository usersRepository;

    @Override
    public Users SaveUser(Users users){
        users.setCreatedAt(LocalDate.now());
        users.setAge(Period.between(users.getDataOfBirth(), LocalDate.now()).getYears());
        return usersRepository.save(users);
    }

    @Override
    public List<Users> fetchUsersList() {
        return (List<Users>) usersRepository.findAll();
    }

    @Override
    public Users updateUsers(Users users, Long Id) {
        Users userDB=usersRepository.findById(Id).get();
        if(Objects.nonNull(users.getName()) && !"".equalsIgnoreCase(users.getName())){
            userDB.setName(users.getName());
        }
        if(Objects.nonNull(users.getEmail()) && !"".equalsIgnoreCase(users.getEmail())){
            userDB.setEmail(users.getEmail());
        }
        if(Objects.nonNull(users.getDataOfBirth()) && !"".equalsIgnoreCase(String.valueOf(users.getDataOfBirth()))){
            userDB.setDataOfBirth(users.getDataOfBirth());
        }
        if(Objects.nonNull(users.getGender()) && !"".equalsIgnoreCase(String.valueOf(users.getGender()))){
            userDB.setGender(users.getGender());
        }
        return usersRepository.save(userDB);


    }

    @Override
    public void DeleteUserById(Long UserId) {
        usersRepository.deleteById(UserId);
    }
    @Override
    public Optional<Users> findUserById(Long Id){
        return usersRepository.findById(Id);
    }
    @Override
    public Iterable<Users> findAllUser(){
        return  usersRepository.findAll();
    }


}
