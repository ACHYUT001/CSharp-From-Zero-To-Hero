using System.IO;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    public class Teacher: ITeacher<Subject>
    {
        public Subject ProduceMaterial()
        {
            return new Subject();
        }
    }
}