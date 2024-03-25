using Prototype;

Teacher teacher = new Teacher("Tim", "Patterns in C#");
Teacher teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher was cloned: {teacherClone.Name} who teaches '{teacherClone.Course}'");

Student student = new Student("James", teacherClone);
Student studentClone = (Student)student.Clone();
Console.WriteLine($"Student was cloned: {studentClone.Name} who is enrolled in {studentClone.Teacher.Name}'s course");

teacherClone.Name = "John";
Console.WriteLine($"Student was cloned: {student.Name} who is enrolled in {student.Teacher.Name}'s course");

