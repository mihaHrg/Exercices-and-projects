using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_0
{
    public class Movie
    {
        public string title;
        public int year;
        public string actor;
        public string genre;

        
        public Movie ()
        {
            this.title = string.Empty;
            this.year = 0;
            this.actor = string.Empty;
            this.genre = string.Empty;
        }
        public Movie(string title, int year, string actor, string genre)
        {
            this.title = title;
            this.year = year;
            this.actor = actor;
            this.genre = genre;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Genre: {genre}");
        }
   
    }
    
   
        

        
     
        }

        
    


