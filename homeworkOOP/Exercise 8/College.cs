using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_8
{
    public class College
    {
        public string Name { get; set; }
        public int FoundedYear {  get; set; }
        public string City {  get; set; }

        public College() 
        {
            Name = "Unknown";
            FoundedYear = 0;
            City = "Unknown";
        }
    }
}

