package Pattern.Composite;

public class Manager implements Person{
    private String name;
    public Manager(String name){
        this.name = name;
    }

    @Override
    public void print() {
        System.out.println("я менежер і мене звати " + name);
    }
}
