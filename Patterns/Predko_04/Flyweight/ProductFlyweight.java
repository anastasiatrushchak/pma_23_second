package org.example.Predko_04.Flyweight;

class ProductFlyweight implements Flyweight {
    private String product;

    public ProductFlyweight(String product) {
        this.product = product;
    }

    @Override
    public void operation() {
        System.out.println("Product: " + product);
    }
}