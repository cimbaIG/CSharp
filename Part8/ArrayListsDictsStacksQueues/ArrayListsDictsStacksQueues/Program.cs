using System;
using System.Collections; // for ArrayLists
using System.Collections.Generic; // for Dictionaries

namespace ArrayListsDictsStacksQueues
{
    public class ArrayListsDictsStacksQueues
    {
        static void Main(string[] args)
        {
            // Unlike arrays collections can be resized.

            // ------------------- ArrayLists -------------------

            // #region provides a way to collapse long blocks of code
            #region ArrayList Code

            // Arraylists are resizable arrays that can hold multiple data types
            ArrayList aList = new ArrayList();

            // Add values of different type to arraylist
            aList.Add("Bob");
            aList.Add(40);

            // Get the number of items in arraylist
            Console.WriteLine("Count: {0}", aList.Count);
            // The capacity of an arraylist automatically increases as items are
            // added.
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            // Create new arraylist
            ArrayList aList2 = new ArrayList();

            // Add an object array to arraylist
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            // Add one arraylist to another arraylist
            aList.AddRange(aList2);

            // Arraylist elements may be sorted or reversed if they are of the
            // same type
            aList2.Sort();
            aList2.Reverse();

            // Insert value at the 2nd position in arraylist
            aList.Insert(1, "Turkey");

            // Get the first two items of an arraylist
            ArrayList range = aList2.GetRange(0, 2);

            // Remove the first item from an arraylist
            aList2.RemoveAt(0);
            // Remove the first two items from an arraylist
            aList2.RemoveRange(0, 2);

            // Search for a match inside an arraylist at the provided index.
            // We can also find the last index with LastIndexOf().
            Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            // Print all items in an arraylist
            foreach (object o in aList)
            {
                Console.WriteLine(o);
            }

            // Convert an arraylist into a string list.
            string[] myArray = (string[])aList2.ToArray(typeof(string));

            // Convert a string array into an arraylist
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            #endregion

            // ------------------- Dictionaries -------------------

            #region Dictionary code

            // Dictionaries store key-value pairs. To create dictionary, we
            // first have to define the data type of the key and the value.
            Dictionary<string, string> superheroes
                = new Dictionary<string, string>();

            // Add some key-value pairs to our dictionary
            superheroes.Add("Clark Kent", "Supermen");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            // Remove a key-value pair from dictionary
            superheroes.Remove("Barry West");

            // Get the number of keys in dictionary
            Console.WriteLine("Count: {0}", superheroes.Count);

            // Check if a key is present inside particular dictionary
            Console.WriteLine("Clark Kent: {0}", superheroes.ContainsKey("Clark Kent"));

            // Get the value of the key and store it into a string
            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine("Clark Kent: {0}", test);

            // Cycle through all the key-value pairs inside dictionary
            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }

            // Clear a dictionary
            superheroes.Clear();

            #endregion

            Console.ReadKey();
        }
    }
}