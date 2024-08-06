using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_3
{
    public class Book
    {
        public string title;
        public string author;
        public int year;
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetAuthor()
        {
            return author;
        }
        public int GetYear()
        {
            return year;
        }

        public void SetAuthor(string author)
        {
            this.author=author;
        }
        public void SetTitle(string title)
        {
            this.title=title;
        }
        public void SetYear(int year)
        {
            this.year=year;
        }
    }
}
