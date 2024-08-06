using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_8
{
    public class Professor
    {
        public string Name {  get; set; }
        public string Faculty {  get; set; }
        public string Specialization {  get; set; }
        public List<string> studentsWhoGiveTheirDegree { get; set;}

        public Professor(string name, string faculty, string specialization)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
        }
        public Professor(string name, string faculty, string specialization, List<string> studentsWhoGiveTheirDegree) : this(name, faculty, specialization)
        {
            Name = name;
            Faculty = faculty;
            Specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }
    }
}
