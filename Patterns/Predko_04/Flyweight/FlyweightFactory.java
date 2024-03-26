package org.example.Predko_04.Flyweight;

import java.util.HashMap;

class FlyweightFactory {
    private HashMap<String, Flyweight> flyweights = new HashMap<>();

    public Flyweight getFlyweight(String key) {
        if (!flyweights.containsKey(key)) {
            flyweights.put(key, new ProductFlyweight(key));
        }
        return flyweights.get(key);
    }
}
