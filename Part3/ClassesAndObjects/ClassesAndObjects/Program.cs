using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();

            // Call the setter
            cat.SetName("Micko");

            // Set the property
            cat.Sound = "Meow";

            Console.WriteLine($"The cat is named {cat.GetName()} and says "
                + $"{cat.Sound}.");

            // Test auto generated getters and setters
            cat.Owner = "Mihael";

            Console.WriteLine($"{cat.GetName()} owner is {cat.Owner}.");

            // Get a read-only id number
            Console.WriteLine($"{cat.GetName()} shelter id is {cat.idNum}.");

            // Test static property
            Console.WriteLine($"Number of animals: {Animal.NumOfAnimals}");

            Console.ReadKey();
        }
    }
}