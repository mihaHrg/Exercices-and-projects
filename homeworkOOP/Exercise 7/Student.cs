using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_7
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public int studentId;
        public double gpa;
        public Student(string firstName, string lastName, int studentId, double gpa)
        {
            if(gpa<=0)
            {
                throw new Exception("Gpa cannot be less than or equal to 0!");
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }

        public string getFullName() 
        {
            return $"{firstName} {lastName}";
        }
        public bool HasHonors()
        {
            return gpa >= 3.5;
        }
    }

}
