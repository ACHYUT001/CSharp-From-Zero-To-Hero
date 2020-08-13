using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Filewriter fw = new Filewriter();
            ConsoleWriter cs = new ConsoleWriter();

            fw.print("Program Starting");
            cs.print("Program starting");

            fw.print("Terminating");
            cs.print("Terminating");
        }
    }
}
