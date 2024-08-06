using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOOP.Exercise_7
{
    public class University
    {
        public string name;
        public List<Student> students;
        public List<Faculty> faculties;

        public University(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.faculties = new List<Faculty>();
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public int GetStudentCount()
        {
            return students.Count;
        }
        public int GetFacultyCount()
        {
            return faculties.Count;
        }
    }
}
