using System;

namespace the_mall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();
            DollarItem MultiColorPen = new DollarItem(){
                Name = "Multi colored Pen with 12 Colors"
            };
            Dollarama.AddToInventory("mcp", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();
            FoodItem ClassicRoll = new FoodItem(){
                Name = "Classic Roll",
                Price = 3.50,
                Calories = 880
            };
            FoodItem PecanBun = new FoodItem(){
                Name = "Caramel Pecanbon",
                Price = 6.00,
                Calories = 1080
            };
            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cp", PecanBun);

            System.Console.WriteLine("Your Inventory:");
            System.Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            System.Console.WriteLine(Cinnabon.GetFromInventory("tcr").Name);
        }
    }
}
