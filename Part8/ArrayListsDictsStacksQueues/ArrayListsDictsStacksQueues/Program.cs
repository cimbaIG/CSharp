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

            Console.ReadKey();
        }
    }
}