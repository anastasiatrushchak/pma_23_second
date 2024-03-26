namespace Prototype;

        public class Teacher: Person
        {
            public Teacher(string name, string course) : base(name)
            {
                Course = course;
            }

            public string Course { get; set; }

            public override Person Clone()
            {
                return (Person)MemberwiseClone();
            }
        }



    

    
   
