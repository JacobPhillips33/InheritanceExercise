using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Predators { get; set; }
        public string Food { get; set; }

        public void PringBirdInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Animal Type: {AnimalType}");
            Console.WriteLine($"Age: {Age} years old");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {Weight} pounds");
            Console.WriteLine($"Food: {Food}");
            Console.WriteLine($"Predators: {Predators}");
        }
    }
}
