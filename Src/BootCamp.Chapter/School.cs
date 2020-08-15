using System.IO;
using BootCamp.Chapter.Hints;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class School : ISchool<Student>
    {
        List<Student> studentList = new List<Student>();
        
        public void AddStudent(Student student)
        {
                studentList.Add(student);
        }

        
        public Student GetStudent(long id)
        {
            return studentList.Find(s => s.Id == id);
        }

    }
}