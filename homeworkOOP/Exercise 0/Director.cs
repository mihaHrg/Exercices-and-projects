using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_0
{
    public class Director
    {
        public string name;
        public int age;
        public Director(string name, int age)
        {
            this.name = name;
            this.age = 0;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Director: {name}");
        }
    }
}
