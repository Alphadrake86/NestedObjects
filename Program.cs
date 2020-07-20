using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor teacher = new Instructor()
            {
                FullName  = "Bob bob",
                Email = "Bob@bob.bob"
            };

            Student s1 = new Student()
            {
                FirstName = "erin",
                LastName  = "e."  
            };

            Student s2 = new Student()
            {
                FirstName = "fill",
                LastName = "f."
            };

            Student s3 = new Student()
            {
                FirstName = "goe",
                LastName = "g."
            };

            Course c = new Course();
            c.Title = "CPW 100 Basic Programming";
            c.Description = "the first one";
            c.Credits = 5;

            c.Instructor = teacher;

            c.ClassRoster = new List<Student>()
            {
                s1, s2, s3
            };

            Console.WriteLine(c.Title);
            Console.WriteLine("Is taught by " + c.Instructor.FullName);

            Console.WriteLine("Currently enrolled:");
            foreach (Student student in c.ClassRoster)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }
    }
}
