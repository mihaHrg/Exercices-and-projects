using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_4
{
    public class Manager : Employee
    {
        public Departament Departament {  get; set; }
        public Manager(string name, int age, double salary, Departament departament) : base (name, age, salary)
        {
            Departament = departament;
        }
        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Departament}, Email: {Name.Replace(" ", string.Empty).ToLower()}@company.com, Phone: [phone]";
        }
    }
}
