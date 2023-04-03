using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Learn more about IEnumerable, Indexer, Enumerator, Operator Overloading,
// Custom Casting, Anonymous Types and more...

namespace Enumerables
{
    // Indexers allows us to access items like arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an AnimalFarm object
            AnimalFarm myAnimals = new AnimalFarm();

            // Add animals to myAnimals
            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Templeton");
            myAnimals[2] = new Animal("Gander");
            myAnimals[3] = new Animal("Charlotte");

            // Print out animal names
            foreach (Animal animal in myAnimals) 
            { 
                Console.WriteLine(animal.Name);
            }

            // Testing operator overloading...
            // Create two box objects
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);

            // Sum two box objects
            Box box3 = box1 + box2;

            // Convert box to a string by using ToString()
            Console.WriteLine($"Box3 : {box3}");
            // Convert box3 to int
            Console.WriteLine($"Box3 as integer : {(int)box3}");

            // Convert an int into a Box object
            Box box4 = (Box)4;
            // Output box4 data
            Console.WriteLine($"Box 4 : {box4}");

            Console.ReadLine();
        }
    }
}
