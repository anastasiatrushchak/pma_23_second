package com.example.demo.Services.Interfaces;

import com.example.demo.Entity.Sellers;
import org.thymeleaf.engine.IThrottledTemplateWriterControl;

import java.util.Optional;

public interface SellersService {
    Sellers SaveSeller(Sellers sellers);
    void DeleteSeller(Long Id);
    Optional<Sellers> FindByIdSeller(Long Id);
    Iterable<Sellers> FindAllSellers();

}
