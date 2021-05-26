namespace SkillsUSA_JacobAngel_Task3
{
    // Author: Jacob Angel
    // Date: 3/27/2021
    class Order
    {
        // Data structure for the Order class
        // Each order has the item ordered, the amount of the item ordered, 
        // and the cost of the order
        public string Item { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }
        public Order(string Item, int Amount, double Cost)
        {
            this.Item = Item;
            this.Amount = Amount;
            this.Cost = Cost;
        }
    }
}