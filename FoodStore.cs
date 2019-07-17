using System.Collections.Generic;

namespace the_mall
{
    public class FoodStore : IStore<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();

        private double _price = 1.00;

        public void AddToInventory(string foodName, FoodItem foodItem)
        {
            _inventory.Add(foodName, foodItem);
        }
        public FoodItem GetFromInventory(string name)
        {
            return _inventory[name];
        }
    }
}