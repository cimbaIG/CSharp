using System;

namespace ConsoleApp1
{
    public class Program
    {

        /*
         Execution begins in the Main() function. Keyword static means that this
         function can run without creating an object. Keyword void means that
         this function does not return a value. "args" represent data that can
         be passed to our program from the command lune as an array of strings.
        */
        static void Main(string[] args)
        {
            // ----------------- Console methods -----------------

            // Change the text color in the console
            Console.ForegroundColor = ConsoleColor.Black;

            // Change background color
            Console.BackgroundColor = ConsoleColor.White;

            // Set background color for entire console
            Console.Clear();

            // Print Hello World to the console
            Console.WriteLine("Hello World!");

            // Print text to the console without a new line
            Console.Write("What is your name? ");

            // Store data entered by the user as a string variable
            string name = Console.ReadLine();

            // Say hello to the user who entered his name
            Console.WriteLine($"Hello {name}!");

            // ----------------- Variables -----------------

            // Variables are used to store different types of data

            // Bool stores true or false
            bool canIVote = true;

            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest integer: {0}", int.MinValue);

            // But what about unsigned integers? Only positive integers!
            Console.WriteLine("Biggest unsinged integer: {0}", uint.MaxValue);
            Console.WriteLine("Smallest unsigned integer: {0}", uint.MinValue);

            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest long: {0}", long.MaxValue);
            Console.WriteLine("Smallest long: {0}", long.MinValue);

            // Decimals store 128-bit precise decimal values.
            Console.WriteLine("Biggest decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Smallest decimal: {0}", decimal.MinValue);
            // Decimals are accurate up to 28 digits.
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC: PI + bigNum = {0}", decPiVal + decBigNum);

            // Doubles are 64-bit float types
            Console.WriteLine("Biggest double: {0}", double.MaxValue);
            Console.WriteLine("Smallest double: {0}", double.MinValue);
            // Doubles are precise up to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // Floats are 32-bit float types.
            Console.WriteLine("Biggest float: {0}",
                float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest float: {0}", float.MinValue);
            // Floats are precise up to0 6 digits.
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            // ----------------- Data type conversion -----------------

            // You can convert from string to other types with Parse
            bool boolFromString = bool.Parse("True");
            int intFromString = int.Parse("100");
            double dblFromString = double.Parse("1.234");

            // Convert double into a string
            string strVal = dblFromString.ToString();

            // Get the data type of specific variable
            Console.WriteLine($"Data type: {strVal.GetType()}");

            // Cast double into integer using explicit conversion
            // Put the data type to convert into between ()
            double dblNum = 12.345;
            Console.WriteLine($"Integer: {(int)dblNum}");

            // Cast integer into long using implicit conversion
            // Smaller size type into a larger size type
            int intNum = 10;
            long longNum = intNum;
            Console.WriteLine($"longNum variable value is {longNum}.");

            // ----------------- Formatting output -----------------

            // Format output for currency
            Console.WriteLine("Currency: {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s: {0:d4}", 23);

            // Define decimals
            Console.WriteLine("Round to three decimals: {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas: {0:n4}", 2300);
        }
    }
}