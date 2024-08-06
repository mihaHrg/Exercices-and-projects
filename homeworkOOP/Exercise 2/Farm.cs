using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_2
{
    public class Farm
    {
        public string name;
        public double area;
        public int animalCount;
      public Farm(string name, double area, int animalCount)
        {
            this.name = name;
            this.area = area;
            this.animalCount = animalCount;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{name} - {area} - {animalCount}");
        }
        public void AddAnimals(int count)
        {
            animalCount += count;
        }
        public double CalculateDensity()
        {
            return (animalCount / area);
        }
       public void PrintDetailss()
        {
            Console.WriteLine($"Total animals now and density: {animalCount} , {animalCount/area}");
        }

    }
}
