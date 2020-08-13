using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class ConsoleWriter:Ilog
    {
        public void print(string input)
        {
            System.Console.WriteLine(input);
        }
    }
}