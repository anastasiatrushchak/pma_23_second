package Pattern.Strategy;

public class Main {
    public static void main(String[] args) {
        Person person1 = new Person("Ольга",
                (name)->"Моє ім'я " +  name);

        System.out.println(person1);
        Person person2 = new Person("Вася",
                (name)-> "Мене звати " + name);
        System.out.println(person2);
    }
}
