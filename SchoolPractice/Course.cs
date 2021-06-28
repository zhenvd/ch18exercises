using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private string CourseName { get; set; }
        private int NumberOfCredits { get; set; }
        private List<string> Roster = new List<string>();
        //private List<string> Roster { get; set; }

        public Course()
        {

        }
        public Course(string CourseName, int NumberOfCredits, List<string> Roster)
        {
            this.CourseName = CourseName;
            this.NumberOfCredits = NumberOfCredits;
            this.Roster = roster;
        }

        public List<string> roster
        {
            get { return Roster; } //set isn't a thing?
        }

        public void AddRoster(string name)
        {
            Roster.Add(name);
        }

        public string name
        {
            get { return name; }
            set { name = value; }
        }

        public int number
        {
            get { return NumberOfCredits; }
            set { NumberOfCredits = value; }
        }
        

    }
}
