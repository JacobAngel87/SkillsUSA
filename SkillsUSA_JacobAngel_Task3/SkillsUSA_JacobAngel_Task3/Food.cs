namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Food
    {
        // Data structure for the Food class
        // Each food has a Name, and a Cost
        public string Name { get; set; }
        public double Cost { get; set; }
        public Food(string Name, double Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}