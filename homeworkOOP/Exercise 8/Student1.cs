using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_8
{
    public class Student1
    {
        public string Name {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string College {  get; set; }
        public DateTime BirthDate { get; set; }

        public Student1(string name, DateTime startDate, DateTime endDate, string college, DateTime birthDate)
        {
            if (startDate>=endDate)
            {
                throw new Exception("The start date of studies must be before the end date!");
            }

            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            College = college;
            BirthDate = birthDate;
        }
        public bool IsStillStudent()
        {
            return DateTime.Now < EndDate;
        }
        
      public int GetAge()
        {
            int age= DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age)) age--;
            return age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}");
            Console.WriteLine($"End Date: {EndDate.ToShortDateString()}");
            Console.WriteLine($"College: {College}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Is Still Student: {IsStillStudent()}");
            Console.WriteLine($"Age: {GetAge()}");
        }
        //am schimbat clasa din ex 8 in student1 pt ca aveam eroare in program
    }
}
