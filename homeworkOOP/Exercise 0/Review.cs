using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_0
{
     public class Review
        {
            public string reviewer;
            public string comment;
            public int rating;
            public Review(string reviewer, string comment, int rating)
            {
                this.reviewer = reviewer;
                this.comment = comment;
                this.rating = rating;
            }
            public void PrintDetails()
            {
                Console.WriteLine($"Reviewer: {reviewer} {comment} {rating}");
            }
        }
}
