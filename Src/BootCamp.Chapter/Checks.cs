using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            System.Console.Write(message);
            int int_number = int.Parse(Console.ReadLine());
            return int_number;
            
        }

        public static string PromptString(string message)
        {
            System.Console.Write(message);
            string string_input = Console.ReadLine();
            return string_input;
        }

        public static float PromptFloat(string message)
        {
            System.Console.Write(message);
            float float_input = float.Parse(Console.ReadLine());
            return float_input;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if(weight<0 || height<0) return -1;
            return (weight/(height * height));   
            
        }
    }
}
