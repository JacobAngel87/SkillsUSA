using System;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task1
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
                if(num < min || num > max) // If the input was not in the desired range
                {
                    WriteLine("INVALID INPUT : Input not in range");
                    continue;
                }
                break;
            }
            return num;
        }
    }
}