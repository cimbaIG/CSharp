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

            Console.ReadLine();
        }
    }
}
