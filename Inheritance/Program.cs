using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE - Be sure to follow best practice when creating your classes

            // DONE - Create a class Animal
            // DONE - give this class 4 members that all Animals have in common


            // DONE - Create a class Bird
            // DONE - give this class 4 members that are specific to Bird
            // DONE - Set this class to inherit from your Animal Class

            // DONE - Create a class Reptile
            // DONE - give this class 4 members that are specific to Reptile
            // DONE - Set this class to inherit from your Animal Class


            /*DONE - Create an object of your Bird class
             *DONE - give values to your members using the object of your Bird class
             *  
             *DONE - Creatively display the class member values 
             */

            Console.WriteLine();
            Console.WriteLine("----------------------Animal 1----------------------------");
            Console.WriteLine();

            var baldEagle = new Bird()
            {
                Name = "Liberty",
                Age = 22,
                AnimalType = "Bird",
                Color = "Dark brown bodies and wings with a white head and tail",
                Species = "Bald Eagle",
                Predators = "Adult bald eagles have few predators, allowing them to nest on the ground without fear.",
                Food = "Bald eagles prey that includes fish, squirrels, wading birds, ducks",                        
                Weight = 12.3
            };

            baldEagle.PringBirdInfo();
           
            /*DONE - Create an object of your Reptile class
             *DONE - give values to your members using the object of your Reptile class
             *  
             *DONE - Creatively display the class member values 
             */

            Console.WriteLine();
            Console.WriteLine("----------------------Animal 2----------------------------");
            Console.WriteLine();

            var tortoise = new Reptile()
            {
                Name = "Master Oogway",
                AnimalType = "Reptile",
                Color = "Green",
                Age = 1000,
                Weight = 250,
                Species = "Tortoise",
                Food = "Vegetables and fruits should make up the main bulk of their diet.",
                Predators = "Roadrunners, snakes, kit foxes and coyotes are a few examples of tortoise predators."
            };

            tortoise.PringReptileInfo();
                        
        }
    }
}
