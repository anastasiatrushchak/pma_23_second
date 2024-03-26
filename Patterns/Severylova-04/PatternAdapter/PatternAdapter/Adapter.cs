using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    public class Adapter : ITarget
    {
        StudentsSystem studentsSystem = new StudentsSystem();

        public void ProcessStudents(string[,] students)
        {

            if (students == null)
            {
                throw new ArgumentNullException(nameof(students), "The students array cannot be null.");
            }

            string Name = null;
            string Surname = null;
            string Age = null;
            string Email = null;

            List<Students> list = new List<Students>();

            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    if (string.IsNullOrWhiteSpace(students[i, j]))
                    {
                        throw new ArgumentException($"Invalid data for student at row {i}, column {j}.");
                    }
                    else if (j == 0)
                    {
                        Name = students[i, j];
                    }
                    else if (j == 1)
                    {
                        Surname = students[i, j];
                    }
                    else if (j == 2)
                    {
                        Age = students[i, j];
                    }
                    else
                    {
                        Email = students[i, j];
                    }

                }
                list.Add(new Students(Name, Surname, Age, Email));
            }
            Console.WriteLine("ADAPTER");
            studentsSystem.Process(list);
        }
    }
}
