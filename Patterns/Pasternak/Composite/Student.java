package Pattern.Composite;

public class Student implements Person{
    public String university;
    public Student(String university){
        this.university = university;
    }
    @Override
    public void print() {
        System.out.println("Я Студент і я навчаюсь в " + university);
    }
}
