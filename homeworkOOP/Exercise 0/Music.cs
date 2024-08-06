using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_0
{
    public class Music
    {
        public string name;
        public int year;
        public string author;
        public Music(string name, int year, string author)
        {
            this.name = name;
            this.year = year;
            this.author=author;

        }
        public void PrintDetails()
        {
            Console.WriteLine($"Music and year: {name} - {year} - {author}");
        }
    }
}
