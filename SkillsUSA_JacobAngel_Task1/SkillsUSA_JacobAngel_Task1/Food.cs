namespace SkillsUSA_JacobAngel_Task1
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Food
    {
        // Data structure for all foods
        // Each food has a Name and Calories count
        public string Name { get; set; }
        public int Calories { get; set; }

        public Food(string Name, int Calories)
        {
            this.Name = Name;
            this.Calories = Calories;
        }
    }
}