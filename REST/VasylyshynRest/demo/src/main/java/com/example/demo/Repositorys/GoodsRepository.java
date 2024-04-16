package com.example.demo.Repositorys;

import com.example.demo.Entity.Goods;
import org.springframework.data.repository.CrudRepository;

public interface GoodsRepository extends CrudRepository<Goods, Long> {
}
