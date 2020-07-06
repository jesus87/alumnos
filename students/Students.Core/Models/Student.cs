using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Core.Models
{
    public class Student
    {
        public Student() {
            Age = 1;
            Grade = 1;
        }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int Grade { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }

        public List<Order> Orders { get; set; }
    }
}
