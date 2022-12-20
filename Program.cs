using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
                {
                    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
                };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            var oldStud = from student in classes
                          from stud in student.Students
                          select stud;

            return oldStud.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }

    internal class OlStudents
    {
        public string Students { get;}
    }
}
