using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Subject { get; set; }
        private int YearsTeaching { get; set; }

        public Teacher(string FirstName, string Lastname, string Subject, int YearsTeaching)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Subject = Subject;
            this.YearsTeaching = YearsTeaching;
        }
    }
}
