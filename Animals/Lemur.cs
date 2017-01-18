using System;
namespace Zoolandia.Animals
{
    // The species for a Lemur
    class Lemur : Animal
    {
        // Define simple properties for a Lemur
        public string food { get; set; }

        public bool fur { get; set; }

        public override void FoodAmount() 
        {
            base.FoodAmount();
            Console.WriteLine("3 lbs. of food per day.");
        }
    }
}