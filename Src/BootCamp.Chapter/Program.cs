using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your username:");
            Console.ReadLine();
            System.Console.WriteLine("Enter your password");

            string a = "\u263A";
            StringBuilder passwordBuilder = new StringBuilder();
            bool continueReading = true;
            char newLineChar = '\r';
            while(continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char passwordChar = consoleKeyInfo.KeyChar;
                Console.OutputEncoding = Encoding.Unicode;
                Console.Write(a);

                if(passwordChar == newLineChar)
                {
                    continueReading = false;
                }
                
                else
                {
                    passwordBuilder.Append(passwordChar.ToString());
                }
            }

            
        }
    }
}
