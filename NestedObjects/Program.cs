using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInstr = new Instructor()
            {
                FullName = "Jake Lohng",
                Email = "Jake.Lohng@cptc.edu"
            };
            Student s1 = new Student()
            {
                FirstName = "George",
                LastName = "Veloz"
            };
            Student s2 = new Student()
            {
                FirstName = "Bob",
                LastName = "Reymos"
            };
            Student s3 = new Student()
            {
                FirstName = "Wilamette",
                LastName = "Perez"
            };
            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - ADV .NET";
            testCourse.Description = "TESSTXTEXTESTESTXTTEST TEXTTSTTEXTTESTTXTTEST";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInstr;
            testCourse.Roster = new List<Student>();

            ///Adding student to course
            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            Console.Write(testCourse.Title);
            Console.WriteLine(" is taught by " + testCourse.CourseInstructor.FullName.ToString());

            Console.WriteLine("Currently Enrolled Students: ");
            foreach(Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }

            Console.ReadKey();
        }
    }
}
