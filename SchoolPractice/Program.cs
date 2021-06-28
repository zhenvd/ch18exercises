using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student vincent = new Student("Vincent", 1, 4.0); //name, number of credits, gpa
            Teacher regi = new Teacher("Reginald", "Beninche", "C#", 5);
            Course csharp = new Course();
            csharp.name = "C#";
            csharp.number = 1;
            csharp.AddRoster(vincent.StudentName);
        }
    }
}
