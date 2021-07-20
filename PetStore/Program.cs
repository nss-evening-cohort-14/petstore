using PetStore.Pets;
using System;

namespace PetStore
{
    class Program
    {
        //static means shared across all instances
        static void Main(string[] args)
        {
            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            //property is privately settable only
            //melba.Weight -= 15;

            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();

            melba.Eat(typeOfFoodForMelba);


            //this won't work, can't dynamically add properties to a class in c#
            //melba.CoatType = "Short";

            var barley = new Dog("Barley",50,"Medium");
            barley.Bark();

            barley.Eat("table scraps");

        }
    }
}
