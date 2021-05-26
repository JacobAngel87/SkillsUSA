using System;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task1
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Program
    {
        static void Main(string[] args)
        {
            // Intro Text
            WriteLine("Welcome to the Calorie Calculator!\n");
            // Creating a new instance of a calculator
            Calculator calculator = new Calculator();
            // Get food inputs from the user
            calculator.GetFoods();
            // Clears the console
            Clear();
            // Generate and display all of the results from the users inputs
            calculator.GenerateResults();
            // Exit Text
            WriteLine("\nThank you for using the Calories Calculator!");
            WriteLine("Press enter key to exit the program...");
            ReadKey();
        }
    }
}