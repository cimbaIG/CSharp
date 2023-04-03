using System;
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

            Console.ReadLine();
        }
    }
}
