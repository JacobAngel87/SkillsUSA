using System.Collections.Generic;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Concession
    {
        // Manager object
        private Manager manager;
        // List of orders
        public List<Order> orders;
        // List of foods
        public List<Food> foods;

        public Concession(Manager manager)
        {
            // Passes the manager from the MainMenu to this class
            this.manager = manager;
            // Declare the list or orders
            orders = new List<Order>();
            // Delcare all of the foods in the concessions
            foods = new List<Food>()
            {
                new Food("Small Popcorn", 3.00),
                new Food("Medium Popcorn", 4.00),
                new Food("Large Popcorn", 5.00),
                new Food("Soda", 2.00),
                new Food("Candy", 1.50)
        };
        }
        // Gets some orders from the user
        public void GoToConcessions()
        {
            WriteLine("Concessions Screen!\n");
            // Gets orders from the user until the user wants to stop
            while(true) // Ordering loop
            {
                // List all of the food items available
                for (int i = 0; i < foods.Count; i++)
                {
                    WriteLine(i + ".) " + foods[i].Name + ": $" + foods[i].Cost);
                }
                // At the end of the menu add an option to return to the main menu
                WriteLine(foods.Count + ".) " + "Return to Main Menu");
                // Ask the user what they want to order
                WriteLine("\nWhat do you want to order?");
                // Gets an input from the user that is in range
                int index = Utils.GetIntFromUser("Input: ", 0, foods.Count);
                // If the input was the last option (Return to the Main Menu)
                if (index == foods.Count)
                {
                    // Clears the console
                    Clear();
                    // Leaves the order loop
                    break;
                }
                // Gets the quantity of the food item they wish to orded
                int amount = Utils.GetIntFromUser("\nHow many of those would you like?: ", 0);
                // Calculates the total cost of the order =
                double cost = foods[index].Cost * amount;
                // Adds the order to the list of orders
                orders.Add(new Order(foods[index].Name, amount, cost));
                // Asks the user if they want to order somthing else
                WriteLine("Do you want to place another order?");
                // Gets an option from the user (yes or no)
                int option = Utils.GetIntFromUser("Type '1' for 'yes', Type '2', for 'no': ", 1, 2);
                // Clears the console
                Clear();
                if (option == 1) continue; // If the user wants to order more items
                else break; // If the user does not
            }
        }
        // Checks out the users orders
        public void GoToCheckout()
        {
            WriteLine("Checkout Screen!\n");
            // Display all of the orders the user has ordered
            WriteLine("Your orders\n");
            for(int i = 0; i < orders.Count; i++)
            {
                WriteLine(orders[i].Amount + " " + orders[i].Item + ": $" + orders[i].Cost);
            }
            // Show them how much is will cost
            WriteLine("Total Cost: $" + GetTotalCost() + "\n");
            // Ask if they want to confirm there orders
            WriteLine("Do you wish to confirm your purchase?");
            // Get the option from the user (yes or no)
            int option = Utils.GetIntFromUser("Type '1' for 'yes', Type '2', for 'no': ", 1, 2);

            if(option == 1) // If yes
            {
                // Proceed with the checkout
                ProceedWithCheckout();
                // Clear the console
                Clear();
                // Thank you message
                WriteLine("Thank you for your purchase!\n");
            } else // If no
            {
                // Clear the console
                Clear();
            }
            
        }
        private void ProceedWithCheckout()
        {
            // Get input for the amount of money the user will pay
            double amountPaid = Utils.GetDoubleFromUser("How much are you going to pay?: ", GetTotalCost());
            // If the user payed more than the cost of the orders
            if(amountPaid > GetTotalCost())
            {
                // Calculate the change back
                double change = amountPaid - GetTotalCost();
                // Give them the change back
                WriteLine("\n$" + change + " is your change.");
            }
            // Wait for the user to conitune the program
            WriteLine("\nPress enter to proceed with checkout.");
            ReadKey();
            // Add the orders to the managers total orders
            manager.AddOrders(orders);
            // Clear the current orders
            orders.Clear();
        }
        // Calculates and returns the total cost of the current order
        private double GetTotalCost()
        {
            double totalCost = 0;
            // Adds all of the orders cost
            for(int i = 0; i < orders.Count; i++)
            {
                totalCost += orders[i].Cost;
            }
            return totalCost;
        }
    }
}