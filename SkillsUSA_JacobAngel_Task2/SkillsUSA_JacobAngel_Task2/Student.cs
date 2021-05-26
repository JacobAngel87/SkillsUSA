using System;
using System.Collections.Generic;
using static System.Console;

namespace SkillsUSA_JacobAngel_Task2
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Student
    {
        // Data structure of student clss
        // Each student has a Name and a ClassName
        public string Name { get; set; }
        public string ClassName { get; set; }

        // List of test scores
        private readonly List<int> testScores;
        // integer for the average test scores
        private int averageTestScore;
        // Letter grade for the average test score
        private string averageTestScoreLetterGrade;
        
        // Consructor of Student class
        public Student(string Name, string ClassName)
        {
            this.Name = Name;
            this.ClassName = ClassName;
            // Declare the test scores as new int list
            testScores = new List<int>();
        }
        // Gets test scores from the user
        public void GetTestScores()
        {
            WriteLine("Test Scores Screen!");
            // Loop continues to get test scores until the user wants to stop
            while (true)
            {
                // Gets a test score between 0 and 100 from the user
                testScores.Add(Utils.GetIntFromUser("\nWhat was the score on your test?: ", 0, 100));
                // Asks the user if they want to continue
                WriteLine("\nDo you want to enter another test score?");
                // Gets an option from the user (yes or no)
                int option = Utils.GetIntFromUser("Type '1' for 'yes', Type '2' for 'no': ", 1, 2);
                if (option == 1) continue; // If the user wants to get another test score
                else break; // Is the user is done entering test scores
            }
        }
        public void GenerateResults()
        {
            WriteLine("Results Screen!\n");
            // Display the students name and the class they just recorded
            WriteLine("Student name: " + Name);
            WriteLine("Recorded class: " + ClassName);
            // Calculate the average test score
            averageTestScore = GetAverageTestScore();
            // Calculate the letter grade associated with the integer grade
            averageTestScoreLetterGrade = Utils.IntToLetterGrade(averageTestScore);
            // Diplay the average test score information
            WriteLine("\nAverage test score: " + averageTestScore + " (" + averageTestScoreLetterGrade + ")");
            // Calculate and display the highest test score enterd by the user
            DisplayHighestTestScore();
            // Calculate and display the lowest test score enterd by the user
            DisplayLowestTestScore();
        }
        // Caclulates and returns the average test score
        private int GetAverageTestScore()
        {
            int total = 0;
            double average;
            for(int i = 0; i < testScores.Count; i++)
            {
                total += testScores[i];
            }
            // Rounds the test score the the nearest integer value
            average = MathF.Round(total / testScores.Count);
            return (int)average;
        }
        // Calculates and displays the highest test score entered by the user
        private void DisplayHighestTestScore()
        {
            int index = 0;
            int highest = -1; // Inital highest value (Everything entered by the user will be higher than the inital value)
            string letterGrade;
            // Loop through all of the awnsers
            for (int i = 0; i < testScores.Count; i++)
            {
                // If the current test score is higher than the previuos highest test score
                if(testScores[i] > highest)
                {
                    // Update the highest test score
                    highest = testScores[i];
                    // Set the index of that test sore
                    index = i + 1;
                }
            }
            // Get the letter grade associated with the integer value
            letterGrade = Utils.IntToLetterGrade(highest);
            // Display the information about the highest test score
            WriteLine("Highest test score (Test #" + index + "): " + highest + " (" + letterGrade + ")");
        }
        // Calculates and displays the lowest test score entered by the user
        private void DisplayLowestTestScore()
        {
            int index = 0;
            int lowest = 101; // Inital lowest value (Everything entered by the user will be lower than the inital value)
            string letterGrade;
            // Loop through all of the awnsers
            for (int i = 0; i < testScores.Count; i++)
            {
                // If the current test score is lower than the previuos highest test score
                if (testScores[i] < lowest)
                {
                    // Update the lowest test score
                    lowest = testScores[i];
                    // Set the index of that test sore
                    index = i + 1;
                }
            }
            // Get the letter grade associated with the integer value
            letterGrade = Utils.IntToLetterGrade(lowest);
            // Display the information about the lowest test score
            WriteLine("Lowest test score (Test #" + index + "): " + lowest + " (" + letterGrade + ")");
        }
    }
}