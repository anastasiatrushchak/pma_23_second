package Pattern.Strategy;

import java.util.function.UnaryOperator;

public class Person {
    public String name;
    public UnaryOperator<String> unaryOperator;

    public Person(String name, UnaryOperator<String> unaryOperator) {
        this.name = name;
        this.unaryOperator = unaryOperator;
    }

    @Override
    public String toString() {
        return unaryOperator.apply(name);
    }
}
