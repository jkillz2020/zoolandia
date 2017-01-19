using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                var JoshAnimal = new Animal();
                JoshAnimal.Name = "Jojo";
                JoshAnimal.Color = "Red";
                JoshAnimal.Weight = 200;
                JoshAnimal.Cuteness = 8;

                Console.WriteLine(JoshAnimal.Cuteness);
                Console.WriteLine(JoshAnimal.Name);

                // var Bob = new Lemur();
                // Bob.FoodAmount();

                var superman = new RedPanda("Jerry");
                Console.WriteLine(superman.Name);

                var Bill = new SpiderMonkey();
                Bill.FoodAmount();

                var myPanda = new RedPanda("Bobby", 500);
                Console.WriteLine("Weight: " + myPanda.Weight);
                Console.WriteLine("Name: " + myPanda.Name);                
        } 
    }
}

