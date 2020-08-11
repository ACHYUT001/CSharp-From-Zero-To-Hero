using System;


namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static void Demo()
        {
            string firstname = Checks.PromptString("Enter your first name:");
            string lastname = Checks.PromptString("Enter your lastname:");
            int age = Checks.PromptInt("Enter your age:");
                  
            float weight = Checks.PromptFloat("Enter Weight in Kg");
            float height = Checks.PromptFloat("Enter height in meters:");
            float bmi = Checks.CalculateBmi(weight, height);
            System.Console.WriteLine($"{firstname} {lastname} is {age} years old, his weight is {weight}, his height is {height} and his BMI is {bmi}");

        }

    }
}