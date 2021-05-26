using static System.Console;

namespace SkillsUSA_JacobAngel_Task2
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Program
    {
        static void Main(string[] args)
        {
            // Intro Text
            WriteLine("Welcome to the Student Grade Calculator!\n");
            // Gets the Name and Class Name from the user
            string name = Utils.GetStringFromUser("What is your name?: ");
            string className = Utils.GetStringFromUser("What class will you be recording?: ");
            // Creating a new student based of the input we just gathered
            Student student = new Student(name, className);
            // Clear the console
            Clear();
            // Get test scores from the user
            student.GetTestScores();
            // Clear the console
            Clear();
            // Generate and Display the results of the test scores entered
            student.GenerateResults();
            // Exit text
            WriteLine("\nThank you for using the Student Grade Calculator!");
            WriteLine("Press enter to exit the program...");
            ReadKey();
        }
    }
}
