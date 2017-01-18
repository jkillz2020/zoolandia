using System;
namespace Zoolandia.Animals
{
    // The species for a Red Panda
    class RedPanda : Animal
    {
        // Define simple properties for a Red Panda
        public string food { get; set; }

        public bool fur { get; set; }

        public override void FoodAmount() 
        {
            base.FoodAmount();
            Console.WriteLine("20 lbs. of food per day.");
        }
    }
}