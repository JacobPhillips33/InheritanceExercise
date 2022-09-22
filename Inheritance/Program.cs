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
                Color = "dark brown bodies and wings with a white head and tail",
                Species = "Bald Eagle",
                Predators = "Adult bald eagles have few predators, allowing them to nest on the ground without fear. " +
                            "The majority of non-human mortality involves nestlings or eggs. Gulls, magpies, black bears, " +
                            "ravens, crows, raccoons, bobcats, wolverines, and arctic foxes frequently prey on the eggs and young.",
                Food = "Bald eagles are opportunistic scavengers with a prey base that includes fish, squirrels, wading birds, ducks " +
                        "and road-killed animals called carrion.",
                Weight = 12.3
            };

            Console.WriteLine($"This animal's name is {baldEagle.Name}.\n{baldEagle.Name} is a {baldEagle.Age} year old " +
                $"{baldEagle.Weight} pound {baldEagle.Species}.\n{baldEagle.Species} is a species of {baldEagle.AnimalType}. " +
                $"They have {baldEagle.Color}.\n{baldEagle.Predators}\n{baldEagle.Food}");


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
                Food = "Although these species are classed as omnivores, greens, flowers, vegetables and fruits should make up " +
                       "the main bulk of their diet.",
                Predators = "Roadrunners, snakes, kit foxes and coyotes are a few examples of tortoise predators."
            };

            Console.WriteLine($"{tortoise.Name} is a {tortoise.Species} which is a type of {tortoise.AnimalType}.\n{tortoise.Name} " +
                $"weighs approximately {tortoise.Weight} pounds and is over {tortoise.Age} years old.\n{tortoise.Name} is " +
                $"{tortoise.Color} in color.\n{tortoise.Food}\n{tortoise.Predators}");
        }
    }
}
