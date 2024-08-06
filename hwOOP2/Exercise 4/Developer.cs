using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_4
{
    public class Developer : Employee
    {
        public List<string> Skills { get; set; }
        public bool IsJunior { get; set; }

        public Developer (string name, int age, double salary, List<string> skills, bool isJunior) :base (name, age, salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Skills = skills;
            IsJunior = isJunior;
        }

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
        public override string GetContactInfo() 
        {
            return $"Name: {Name}, Age: {Age}, Skills: {string.Join(", ", Skills)}, Email: {Name.Replace(" ", string.Empty).ToLower()}@company.com, Phone: [phone]";
        }
    }
}
