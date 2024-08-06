using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_0
{
    public class Actors
    {
        public string nameActor1;
        public string nameActor2;
        public string nameActor3;
        public string nameActor4;
        public string nameActor5;
        public Actors(string nameActor1, string nameActor2, string nameActor3, string nameActor4, string nameActor5)
        {
            this.nameActor1 = nameActor1;
            this.nameActor2 = nameActor2;
            this.nameActor3 = nameActor3;
            this.nameActor4 = nameActor4;
            this.nameActor5 = nameActor5;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Actors are: {nameActor1},{nameActor2},{nameActor3},{nameActor4},{nameActor5}");
        }
    }
}
