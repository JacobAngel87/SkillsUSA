using static System.Console;

namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class MainMenu
    {
        // Private Objecst
        private readonly Concession con;
        private readonly Manager manager;
        
        // Main loop logic bool
        private bool running;
        public MainMenu()
        {
            // Declare the manager and the concession objects
            manager = new Manager(this);
            con = new Concession(manager);
            // Set running to true
            running = true;
        }
        public void Start()
        {
            // Intro text
            WriteLine("Welcome to the Movie Theater Concessions!\n");
            // Main Loop
            while(running)
            {
                // Display the different options for the user
                WriteLine("1.) Concessions");
                WriteLine("2.) Checkout");
                WriteLine("3.) Manager");
                WriteLine("4.) Exit\n");
                // Get a option from the user from the available options
                int option = Utils.GetIntFromUser("Input: ", 1, 4);
                // Clear the console
                Clear();
                // Preform whatever option the user specified
                switch (option)
                {
                    case 1:
                        con.GoToConcessions(); // Concessions option
                        break;
                    case 2:
                        con.GoToCheckout(); // Checkout option
                        break;
                    case 3:
                        manager.LogIn(); // Manager option
                        break;
                    case 4:
                        // Breaks out of the main loop
                        running = false; // Exit option
                        break;
                }
            }   
        }
        // Getter for the concession object
        public Concession GetConcession()
        {
            return con;
        }
    }
}