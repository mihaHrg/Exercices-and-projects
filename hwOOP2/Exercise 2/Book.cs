using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; private set; }

        public Book(string title, string author, int pageCount) 
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            CurrentPage = 1;
        }   
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        { 
            return Author; 
        }
        public int GetPageCount()
        {
            return PageCount;
        }
        public int GetCurrentPage()
        { 
            return CurrentPage;
        }
        public void NextPage()
        {
            if (CurrentPage < PageCount)
            { 
                CurrentPage++;
            }
        }
        public void PreviousPage()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
            }
        }
    }
}
