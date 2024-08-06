using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary) 
        { 
            Name = name;
            Age = age;
            Salary = salary;
        }

        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Email: {Name.Replace(" ", string.Empty).ToLower()}@company.com, Phone: [phone]";
        }

    }
}

