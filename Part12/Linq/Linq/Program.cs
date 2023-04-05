using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    // Language Integrated Query (LINQ) provides many tools for working with
    // data. LINQ is similar to SQL, but it can work with data aside from
    // databases. One can manipulate data using Query Expressions.
    internal class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();

            // Get the array returned and print it
            int[] intArray = QueryIntArray();

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            QueryArrayList();

            QueryCollection();

            Console.ReadKey();
        }

        static void QueryStringArray()
        {
           // Define an array containing dog names
            string[] dogs = {"K 9", "Brian Griffin", "Scooby Doo", "Old Yeller",
                "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy"};

            // Get all the strings from array that contain spaces and put them
            // in alphabetical order.

            // from keyword states where the data comes from and where to store
            // each piece as we cycle.

            // where keyword defines conditions that must be met.

            // orderby defines what data is used for ordering results
            // (ascending / descending).

            // select keyword defines the variable that is checked against the
            // condition.

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces) 
            { 
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            // Get all the numbers bigger than 20
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // The type is an enumerable
            Console.WriteLine($"Get Type: {gt20.GetType()}");

            // We can convert it to a List or an array
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            // If we decide to change the data, the query automatically
            // updates.
            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            return arrayGT20;
        }

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{ Name = "Heidi", Height = .8, Weight = 18 },
                new Animal{ Name = "Shrek", Height = 4, Weight = 130 },
                new Animal{ Name = "Congo", Height = 3.8, Weight = 90 }
            };

            // We have to convert the ArrayList into an IEnumerable
            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var animal in smAnimals)
            {
                Console.WriteLine("{0} weighs {1}lbs", animal.Name,
                    animal.Weight);
            }

            Console.WriteLine();
        }

        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 25,
                    Weight = 77
                },
                new Animal
                {
                    Name = "Chihuahua",
                    Height = 7,
                    Weight = 4.4
                },
                new Animal
                {
                    Name = "Saint Bernard",
                    Height = 30,
                    Weight = 200
                }
            };

            // Convert animalList to IEnumerable
            var animalListEnum = animalList.OfType<Animal>();

            var bigDogs = from dog in animalListEnum
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}lbs.",
                    dog.Name, dog.Weight);
            }

            Console.WriteLine();
        }
    }
}
