package com.example.demo.Controllers;

import com.example.demo.Entity.Sellers;
import com.example.demo.Services.Interfaces.SellersService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/sellers")
public class SellersController {
    @Autowired
    private SellersService sellersService;
    @PostMapping
    public Sellers AddSeller(@Validated @RequestBody Sellers sellers){
        return sellersService.SaveSeller(sellers);
    }
    @GetMapping
    public Object GetSeller(@RequestParam(required = false) Long Id){
        if(Id==null){
            return sellersService.FindAllSellers();
        }return sellersService.FindByIdSeller(Id);
    }
    @DeleteMapping
    public String DeleteSeller(@RequestParam Long Id){
        sellersService.DeleteSeller(Id);
        return "deleted with id "+Id;
    }
}
