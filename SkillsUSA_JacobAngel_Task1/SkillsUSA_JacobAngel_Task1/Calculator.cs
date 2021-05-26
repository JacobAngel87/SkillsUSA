using System;
using System.Collections.Generic;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task1
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Calculator
    {
        // List for all of the food data
        private readonly List<Food> foodItems;
        private readonly List<int> foodAmounts;

        // Constant calorie burning variables
        private const int CALORIES_BURNT_JOGGING = 398,
            CALORIES_BURNT_RUNNING = 557;
        private int totalCalories;

        // Floats used for calculating the number of hours it would take to burn the calories off
        private float hoursJogging;
        private float hoursRunning;
        public Calculator()
        {
            // Declaring all of the foods
            foodItems = new List<Food>()
            {
                new Food("Big Mac", 563),
                new Food("Medium Fry", 378),
                new Food("Small Shake", 530)
            };
            // Declaring the food amounts list
            foodAmounts = new List<int>();
        }
        public void GetFoods()
        {
            // Asks the user to input the quantitiy of each food item they consumed
            for(int i = 0; i < foodItems.Count; i++)
            {
                foodAmounts.Add(Utils.GetIntFromUser("How many " + foodItems[i].Name + "'s did you consume?: ", 0));
            }
        }
        public void GenerateResults()
        {
            WriteLine("Results Screen!\n");
            // Displays all of the food items and amount of each item the user has consumed
            for (int i = 0; i < foodItems.Count; i++)
            {
                // Calculates the total calories for each indvidual food item
                int caloriesPerItem = foodItems[i].Calories * foodAmounts[i]; 
                WriteLine("You consumed " + foodAmounts[i] + " " + foodItems[i].Name + "'s for a total of " + caloriesPerItem + " calories.");
                // Add the item calories to the total calories
                totalCalories += caloriesPerItem;
            }
            // Display the total calories
            WriteLine("\nTotal calories consumed: " + totalCalories);
            // Calculates the amount of hours you would need to jog and run to burn off the total calories
            // Rounds each number to the nearest hundreth
            hoursJogging = MathF.Round((float)totalCalories / CALORIES_BURNT_JOGGING, 2);
            hoursRunning = MathF.Round((float)totalCalories / CALORIES_BURNT_RUNNING, 2);
            // Display the calculations from above
            WriteLine("\nIt would take " + hoursJogging + " hours of jogging to burn off all those calories!");
            WriteLine("It would only take " + hoursRunning + " hours of running to burn them off!");
        }
    }
}