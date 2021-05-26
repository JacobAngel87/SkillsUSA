using System;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task2
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Utils
    {
        // Returns an int from the user
        // Optional Parameters for Min and Max values if desired
        public static int GetIntFromUser(string prompt, int min = Int32.MinValue, int max = Int32.MaxValue)
        {
            string input;
            int num;
            // Continues to get user input until the user inputs something correct
            while (true)
            {
                Write(prompt);
                input = ReadLine();
                if (!Int32.TryParse(input, out num)) // If the input was not an integer
                {
                    WriteLine("INVALID INPUT : Input must be Integer");
                    continue;
                }
                if (num < min || num > max) // If the input was not in the desired range
                {
                    WriteLine("INVALID INPUT : Input not in range");
                    continue;
                }
                break;
            }
            return num;
        }
        // Returns a string from the user that cannot be empty
        public static string GetStringFromUser(string prompt)
        {
            string input;
            // Ask the user for input until they give a string that is not empty
            while (true)
            {
                Write(prompt);
                input = ReadLine();
                if(input == null || input.Length < 1) // If the string is empty
                {
                    WriteLine("INVALID INPUT : Input cannot be blank");
                    continue;
                }
                break;
            }
            return input;
        }
        // Returns a letter grade based of the input given to the method
        public static string IntToLetterGrade(int grade)
        {
            string letterGrade = "";

            // If the int grade is out of bounds
            if(grade > 100 || grade < 0)
            {
                return "NA";
            }
            if(grade >= 90) // If the int grade was an "A"
            {
                letterGrade = "A";
            }
            else if(grade >= 80) // If the int grade was an "B"
            {
                letterGrade = "B";
            }
            else if(grade >= 70) // If the int grade was an "C"
            {
                letterGrade = "C";
            }
            else if(grade >= 60) // If the int grade was an "D"
            {
                letterGrade = "D";
            }
            else if(grade < 60) // If the int grade was an "F"
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
    }
}