﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{

    // This lecture covers multiple functions we can use to work with lists of data,
    // including Lambda, Where, ToList, Select, Zip, Aggregate and Average.

    class Program
    {
        // Delegate that is assigned a Lambda expression.
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            // ----------------------- Lambda functions -----------------------

            // Lambda expressions allow us to use anonymous methods that define
            // the input parameters on the left and the code to execute on the right.

            // Assign a Lambda to the delegate
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            // Of course, we do not have to use delegates with lambda functions.
            // We can search through a list to find all even numbers using the lambda
            // functions.
            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };
            // Put the even number in the list evenList if condition is true.
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList) 
                Console.WriteLine(j);

            // Add all values between 2 and 9 to a list rangeList.
            var rangeList = numList.Where(x => (x > 2) & (x < 9)).ToList();
            foreach (var j in rangeList) 
                Console.WriteLine(j);

            // Find the number of heads and tails in a list 1 = H, 2 = T.
            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            // Print out the heads and the tails in the flipList.
            Console.WriteLine("Heads: {0}", 
                flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails: {0}", 
                flipList.Where(a => a != 1).ToList().Count());

            // Find all names starting with s
            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var name in sNameList)
                Console.WriteLine(name);

            // ----------------------- SELECT -----------------------

            // Select allows us to execute function on each item in a list.

            // Generate a list from 1 to 10
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach (var l in squares)
            {
                Console.WriteLine(l);
            }

            // ----------------------- ZIP -----------------------

            // Zip applies a function to two lists.
            //
            // For instance, add values in two lists together.
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (var l in sumList)
                Console.WriteLine(l);

            // ----------------------- AGGREGATE -----------------------

            // Aggregate performs an operation on each item in a list and
            // carries the result forward.

            // Sum values in a list
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum: {0}",
                numList2.Aggregate((a, b) => a + b));

            // ----------------------- AVERAGE -----------------------

            // Get the average value of a list of values.

            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Average: {0}",
                numList3.AsQueryable().Average());

            // ----------------------- ALL -----------------------

            // Determines if all items in a list meet a condition.

            var numList4 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("All > 3: {0}",
                numList4.All(a => a > 3));

            // ----------------------- ANY -----------------------

            // Determines if any item in a list meet a condition.

            var numList5 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Any > 3: {0}",
                numList5.Any(a => a > 3));

            // ----------------------- DISTINCT -----------------------

            // Eliminates duplicates from a list.

            var numList6 = new List<int>() { 1, 2, 3, 2, 3 };
            Console.WriteLine("Distinct: {0}",
                string.Join(", ", numList6.Distinct()));

            // ----------------------- EXCEPT -----------------------

            // Receives two lists and returns values that do not exist in
            // the 2nd list.

            var numList7 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList8 = new List<int>() { 3 };
            Console.WriteLine("Except: {0}",
                string.Join(", ", numList7.Except(numList8)));

            // ----------------------- INTERSECT -----------------------

            // Receives two lists and returns the values that both lists have.

            var numList9 = new List<int>() { 1, 2, 3, 2, 3 };
            var numList10 = new List<int>() { 3 };
            Console.WriteLine("Intersect: {0}",
                string.Join(", ", numList9.Intersect(numList10)));

            Console.ReadLine();
        }
    }
}
