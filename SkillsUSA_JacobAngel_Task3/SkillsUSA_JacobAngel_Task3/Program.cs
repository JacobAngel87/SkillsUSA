using static System.Console;

namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and starts a new MainMenu
            MainMenu menu = new MainMenu();
            menu.Start();
            // Exit Text
            WriteLine("Thank you for using Movie Theater Concessions!");
            WriteLine("Press enter to exit program...");
            ReadKey();
        }
    }
}