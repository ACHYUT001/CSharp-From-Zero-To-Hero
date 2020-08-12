using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            string line;
            List<string> peopleBalance = new List<string>();
            using(StreamReader r_file = new StreamReader(dirtyFile))
            {
                System.Console.WriteLine("Starting file cleaning!");
                using(StreamWriter w_file = new StreamWriter(cleanedFile))
                {
                    while( (line = r_file.ReadLine()) != null )
                    {
                        string cleaned_string = line.Replace("_","");
                        peopleBalance.Add(cleaned_string);
                        w_file.WriteLine(cleaned_string);
                    }
                }
            }

            System.Console.WriteLine("File cleaning completed!");

            PeoplesBalances.Balances = peopleBalance;
            
        }
    }
}
