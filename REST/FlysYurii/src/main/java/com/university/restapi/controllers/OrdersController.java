package com.university.restapi.controllers;

import com.university.restapi.entities.Product;
import com.university.restapi.entities.User;
import com.university.restapi.exceptions.ResourceNotFoundException;
import com.university.restapi.services.ProductsService;
import com.university.restapi.services.UserService;
import org.springframework.web.bind.annotation.*;
import com.university.restapi.services.OrdersService;
import com.university.restapi.entities.Order;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;

@RestController
@RequestMapping("/orders")
public class OrdersController {
//    {
//    "user": {
//        "userId": 5
//    },
//    "product": {
//        "productId": 1
//    },
//    "quantity": 1000
//}

    @Autowired
    private OrdersService ordersService;

    @Autowired
    private ProductsService productsService;

    @Autowired

    private UserService usersService;

    @GetMapping("/{id}")
    public Order getOrder(@PathVariable Integer id) {
        Order order = ordersService.getOrder(id);
        if (order == null) {
            throw new ResourceNotFoundException("Order with id " + id + " not found");
        }
        return order;
    }

    @PostMapping
    public void addOrder(@RequestBody Order order) {
        if (order == null) {
            throw new IllegalArgumentException("Order cannot be null");
        }
        ordersService.addOrder(order);
    }

    @PutMapping("/{id}")
    public void updateOrderbyParams(@PathVariable Integer id, @RequestParam Integer userId, @RequestParam Integer productId, @RequestParam Integer quantity) {
        Order orderToUpdate = ordersService.getOrder(id);
        if (orderToUpdate == null) {
            throw new ResourceNotFoundException("Order with id " + id + " not found");
        }
        User user = usersService.getUser(userId);
        if (user == null) {
            throw new ResourceNotFoundException("User with id " + userId + " not found");
        }
        Product product = productsService.getProduct(productId);
        if (product == null) {
            throw new ResourceNotFoundException("Product with id " + productId + " not found");
        }
        orderToUpdate.setUser(user);
        orderToUpdate.setProduct(product);
        orderToUpdate.setQuantity(quantity);
        ordersService.updateOrder(orderToUpdate);
    }

    @PatchMapping("/{id}")
    public void updateOrderbyHeader(@PathVariable Integer id, @RequestHeader Integer userId, @RequestHeader Integer productId, @RequestHeader Integer quantity) {
        Order orderToUpdate = ordersService.getOrder(id);
        if (orderToUpdate == null) {
            throw new ResourceNotFoundException("Order with id " + id + " not found");
        }
        User user = usersService.getUser(userId);
        if (user == null) {
            throw new ResourceNotFoundException("User with id " + userId + " not found");
        }
        Product product = productsService.getProduct(productId);
        if (product == null) {
            throw new ResourceNotFoundException("Product with id " + productId + " not found");
        }
        orderToUpdate.setUser(user);
        orderToUpdate.setProduct(product);
        orderToUpdate.setQuantity(quantity);
        ordersService.updateOrder(orderToUpdate);
    }

    @DeleteMapping("/{id}")
    public void deleteOrder(@PathVariable Integer id) {
        Order order = ordersService.getOrder(id);
        if (order == null) {
            throw new ResourceNotFoundException("Order with id " + id + " not found");
        }
        ordersService.deleteOrder(id);
    }

    @GetMapping("/users/{id}")
    public User getUser(@PathVariable Integer id) {
        User user = usersService.getUser(id);
        if (user == null) {
            throw new ResourceNotFoundException("User with id " + id + " not found");
        }
        return user;
    }

    @PostMapping("/users")
    public void addUser(@RequestBody User user) {
        if (user == null) {
            throw new IllegalArgumentException("User cannot be null");
        }
        usersService.addUser(user);
    }

    @PatchMapping("/users/{id}")
    public void updateUser(@PathVariable Integer id, @RequestBody User user) {
        User userToUpdate = usersService.getUser(id);
        if (userToUpdate == null) {
            throw new ResourceNotFoundException("User with id " + id + " not found");
        }
        if (user == null) {
            throw new IllegalArgumentException("User cannot be null");
        }
        userToUpdate.setName(user.getName());
        userToUpdate.setEmail(user.getEmail());
        usersService.updateUser(userToUpdate);
    }

    @DeleteMapping("/users/{id}")
    public void deleteUser(@PathVariable Integer id) {
        User user = usersService.getUser(id);
        if (user == null) {
            throw new ResourceNotFoundException("User with id " + id + " not found");
        }
        usersService.deleteUser(id);
    }

    @GetMapping("/products/{id}")
    public Product getProduct(@PathVariable Integer id) {
        Product product = productsService.getProduct(id);
        if (product == null) {
            throw new ResourceNotFoundException("Product with id " + id + " not found");
        }
        return product;
    }

    @PostMapping("/products")
    public void addProduct(@RequestBody Product product) {
        if (product == null) {
            throw new IllegalArgumentException("Product cannot be null");
        }
        productsService.addProduct(product);
    }

    @PatchMapping("/products/{id}")
    public void updateProduct(@PathVariable Integer id, @RequestBody Product product) {
        Product productToUpdate = productsService.getProduct(id);
        if (productToUpdate == null) {
            throw new ResourceNotFoundException("Product with id " + id + " not found");
        }
        if (product == null) {
            throw new IllegalArgumentException("Product cannot be null");
        }
        productToUpdate.setName(product.getName());
        productToUpdate.setPrice(product.getPrice());
        productsService.updateProduct(productToUpdate);
    }

    @DeleteMapping("/products/{id}")
    public void deleteProduct(@PathVariable Integer id) {
        Product product = productsService.getProduct(id);
        if (product == null) {
            throw new ResourceNotFoundException("Product with id " + id + " not found");
        }
        productsService.deleteProduct(id);
    }
}
