package Pattern.Composite;

public class Main {
    public static void main(String[] args) {
        GroupPerson groupPerson = new GroupPerson();
        groupPerson.add(new Manager("Максим"));
        groupPerson.add(new Student("ЛНУ"));
        groupPerson.add(new Manager("Катя"));

        groupPerson.printAllList();
    }
}
