using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Weight { get; set; }

        public int Cuteness { get; set; }

        public virtual void FoodAmount()
        {
            Console.WriteLine("I need to eat");
        }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
}