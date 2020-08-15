using System.IO;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter
{
    public class Student : IStudent
    {
        public long Id { get;}

        Teacher teacheris;
   //Subject subject = new Subject();
        public void LearnFrom(out Teacher teacher)
        {
            teacheris = teacher;
        }



    
    }
}