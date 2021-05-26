using System;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task3
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
                if (input == null || input.Length < 1) // If the string is empty
                {
                    WriteLine("INVALID INPUT : Input cannot be blank");
                    continue;
                }
                break;
            }
            return input;
        }
        // Returns a double from the user
        // Optional Parameters for Min and Max values if desired
        public static double GetDoubleFromUser(string prompt, double min = Int32.MinValue, double max = Int32.MaxValue)
        {
            string input;
            double num;
            // Continues to get user input until the user inputs something correct
            while (true)
            {
                Write(prompt);
                input = ReadLine();
                if (!Double.TryParse(input, out num)) // If the input was not a double
                {
                    WriteLine("INVALID INPUT : Input must be Double");
                    continue;
                }
                if (num < min || num > max)
                {
                    WriteLine("INVALID INPUT : Input not in range"); // If the input was not in the desired range
                    continue;
                }
                break;
            }
            return num;
        }
    }
}