using System;
using System.IO;


namespace BootCamp.Chapter
{
    public class Filewriter : Ilog
    {
        public void print(string input)
        {
            string path = @"C:\Users\acupadhy\source\repos\ACHYUT001\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\log.txt";
            using( StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(input);
            }
        }
    }
}