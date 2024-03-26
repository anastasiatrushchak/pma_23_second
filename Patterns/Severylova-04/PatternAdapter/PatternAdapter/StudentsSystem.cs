using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    public class StudentsSystem
    {
        public void Process(List<Students> list)
        {
            foreach(Students student in list)
            {
                Console.WriteLine(student.Name + " " + student.Surname + "  age: " + student.Age +"  account: " + student.Email);
            }
        }
    }
}
