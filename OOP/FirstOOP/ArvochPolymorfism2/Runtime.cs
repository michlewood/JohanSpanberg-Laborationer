using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism2
{
    class Runtime
    {
        public void Start()
        {
            
            Student myStudent = new Student { Name = "Johan", Age = 30, City = "Härnösand", Class = "SU16" };
            Teacher myTeacher = new Teacher { Name = "John", Age = 53, City = "Stockholm", Subject = "Systemutveckling" };

            Console.WriteLine(myStudent.Introduction());
            Console.WriteLine(myTeacher.Introduction());
            
        }

        
    }
}
