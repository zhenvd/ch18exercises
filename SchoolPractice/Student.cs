using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name;
        private int StudentId;
        private int NumberOfCredits;
        private double Gpa;

        public Student(string Name, int StudentId, int NumberOfCredits, double Gpa)
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.NumberOfCredits = NumberOfCredits;
            this.Gpa = Gpa;
        }

        public Student(string Name, int NumberOfCredits, double Gpa)
        {
            this.Name = Name;
            this.NumberOfCredits = NumberOfCredits;
            this.Gpa = Gpa;
        }

        public string StudentName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int StudentID
        {
            get { return StudentId; }
            set { StudentId = value; }
        }

        public int NoOfCredits
        {
            get { return NumberOfCredits; }
            set { NumberOfCredits = value; }
        }

        public double GPA
        {
            get { return Gpa; }
            set { Gpa = value; }
        }

    }
}
