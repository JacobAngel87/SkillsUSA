using System.Collections.Generic;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Manager
    {
        // List of all orders for the day
        private readonly List<Order> todaysOrders;
        // MainMenu object
        private readonly MainMenu menu;
        // Password keywords
        private const string PASSWORD = "7777";
        private const string EXIT_KEYWORD = "EXIT";
        // List of all items sold 
        private readonly List<int> itemsSold;
        // List of all foods
        private List<Food> foods;
        // Total sales for today
        private double grossSales;
        public Manager(MainMenu menu)
        {
            // Declare the lists
            todaysOrders = new List<Order>();
            itemsSold = new List<int>();
            this.menu = menu; // Inherits the main menu
        }
        public void LogIn()
        {
            // Gets passwords from the user until they enter one of the keywords
            while (true) // Password Loop
            {
                string input = Utils.GetStringFromUser("Password (Type 'EXIT' to leave): ");
                if (input == PASSWORD) // If they enter the password
                {
                    // Show the orders for today
                    ShowTodaysOrders();
                    // Exit the password loop
                    break;
                }
                // If they eneter the exit keyword
                // Exit the password loop
                else if (input == EXIT_KEYWORD) break;
            }
            // Clear the console
            Clear();
        }
        // Displays the information about the orders for today
        private void ShowTodaysOrders()
        {
            // Clear all of the items
            itemsSold.Clear();
            // Get the current list of foods from the concessions
            foods = menu.GetConcession().foods;
            // Reset the sales
            grossSales = 0;
            WriteLine("\nTodays Orders\n");
            // Caclculate all of the statistics about the day
            CaclulateStatistics();

            // Display info about each food item
            for (int i = 0; i < foods.Count; i++)
            {
                WriteLine("Amount of " + foods[i].Name + " sold today: " + itemsSold[i]);
            }
            // Display the total gross for the day
            WriteLine("\nTotal gross sales: $" + grossSales);
            // Wait for user input to continue the program
            WriteLine("\nPress enter to continue the program...");
            ReadKey();
        }

        private void CaclulateStatistics()
        {
            // Adds an element for each food item
            for (int i = 0; i < foods.Count; i++)
            {
                itemsSold.Add(0);
            }
            // Calculates the gross sales and the quantity for each item sold 
            for (int i = 0; i < todaysOrders.Count; i++) // Loop thourgh all of the orders
            {
                string item = todaysOrders[i].Item; // Current order
                for (int j = 0; j < foods.Count; j++) // Loop through all of the foods
                {
                    if (item == foods[j].Name) // Find the current food
                    {
                        // Add the quantity to that foods element
                        itemsSold[j] += todaysOrders[i].Amount;
                        // Add to the gross sales
                        grossSales += todaysOrders[i].Cost;
                    }
                }
            }
        }
        // Adds a list of orders to the list of todays orders
        public void AddOrders(List<Order> orders)
        {
            // Loop through each order given and add it to todays orders
            for (int i = 0; i < orders.Count; i++)
            {
                todaysOrders.Add(orders[i]);
            }
        }
    }
}