using System;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    public class Program
    {
        // Function prints the element values of an array
        static void PrintArray(int[] intArray, string msg)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine($"{msg}: {k}");
            }
        }

        // Function to divide two double type numbers
        static double DoDivision(double a, double b)
        {
            if (b == 0)
            {
                // We are throwing an exception because it is not possible to
                // divide by zero.
                throw new System.DivideByZeroException();
            }
            return a / b;
        }

        // Function to print hello to console.
        private static void SayHello()
        {
            // A string variable that is going to store the users input.
            string name = "";
            Console.Write("What is your name? ");
            // Store users input
            name = Console.ReadLine();
            // Say hello to user
            Console.WriteLine($"Hello, {name}!");
        }

        // We can define a default argument value in a function declaration. In
        // that case it is optional to pass this argument.
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        // An argument marked with out must be assigned a value inside the
        // method.
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // Pass an argument as reference.
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // The params array must be the last parameter in the list of arguments!
        public static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i; // sum = sum + i;
            }
            return sum;
        }

        // Example of named parameters
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine($"{name} lives in the zip code {zipCode}.");
        }

        /*
         Execution begins in the Main() function. Keyword static means that this
         function can run without creating an object. Keyword void means that
         this function does not return a value. "args" represent data that can
         be passed to our program from the command lune as an array of strings.
        */
        static void Main(string[] args)
        {
            // ----------------- Console methods -----------------

            //// Change the text color in the console
            //Console.ForegroundColor = ConsoleColor.Black;

            //// Change background color
            //Console.BackgroundColor = ConsoleColor.White;

            //// Set background color for entire console
            //Console.Clear();

            //// Print Hello World to the console
            //Console.WriteLine("Hello World!");

            //// Print text to the console without a new line
            //Console.Write("What is your name? ");

            //// Store data entered by the user as a string variable
            //string name = Console.ReadLine();

            //// Say hello to the user who entered his name
            //Console.WriteLine($"Hello {name}!");

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

            // ----------------- Strings -----------------

            // Strings store a series of characters
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String length: {0}", randString.Length);

            // Check if string contains another string
            Console.WriteLine("String contains 'is': ",
                randString.Contains("is"));

            // Get index of substring inside the string
            Console.WriteLine("Index of 'is': {0}", randString.IndexOf("is"));

            // Remove 10 characters from the string starting at an index 6
            Console.WriteLine("Remove string : {0}",
                randString.Remove(10, 6));

            // Add a string starting at index 10
            Console.WriteLine("Insert string: {0}",
                randString.Insert(10, "short "));

            // Replace string with another string
            Console.WriteLine("Replace string: {0}",
                randString.Replace("string", "sentence"));

            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1
            Console.WriteLine("Compare A to B: {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a: {0}",
                String.Compare("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left: {0}", randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right: {0}", randString.PadRight(20, '.'));

            // Trim whitespace
            Console.WriteLine("Trim: {0}", randString.Trim());

            // Make uppercase
            Console.WriteLine("Uppercase: {0}", randString.ToUpper());

            // Make lowecase
            Console.WriteLine("Lowercase: {0}", randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}.",
                "Paul", "rabbit", "eating", "field");

            // You can add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            // Other escape characters
            // \' \" \\ \t \a

            // Verbatim strings ignore escape characters
            Console.WriteLine(@"Exactly What I Typed\n");

            // ----------------- Arrays -----------------

            // Arrays are boxes inside of a bigger box that can contain many
            // values of the same data type. Each item is assigned a key
            // starting at 0 and incrementing up from there.

            // An array of ints which holds three int values.
            // Important - Arrays have fixed sizes!
            int[] favNums = new int[3];

            // Add a value to the first element of an array
            favNums[0] = 23;

            // Retrieve a value from first element of an array
            Console.WriteLine("favNum value at position 0: {0}", favNums[0]);

            // Create array of strings and fill it with values
            string[] customers = { "Bob", "Sally", "Sue" };

            // The var keyword may be used to create arrays, but the values have
            // to be of the same type.
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the base type of all
            // other types.
            object[] randomArray = { "Paul", 45, 1.234 };

            // Determine the data type of array element using GetType()
            Console.WriteLine("The type of first element in array: {0}",
                randomArray[0].GetType());

            // Get number of items in an array
            Console.WriteLine("Array size: {0}", randomArray.Length);

            // Use for loop to cycle through an array and to print its values
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("At array index {0}, value is {1}.",
                    i, randomArray[i]);
            }

            // Multidimensional arrays
            // When an array like arrayName[5] is defined, we basically say that
            // we want to create boxes that are stacked vertically.
            // If we define an array like arrayName[2,2], we say that we want to
            // create two create array that is two rows high and that have two
            // columns accross.
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" },
                { "Sally", "Smith" } };

            // Get a value of an element in multidimensional array
            Console.WriteLine("Value of an element in multidimensional array:" +
                " {0}", custNames.GetValue(1, 1));

            // Cycle through the multidimensional array and print element values
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.WriteLine($"Array index [{i}][{k}]: "
                        + $"Value = {custNames.GetValue(i, k)}");
                }
            }

            // An array like arrayName[2,2,3] would be like a stack of three
            // spreadsheets with two rows and two columns worth of data on each
            // page.

            // foreach may be used to easily cycle through the array elements
            foreach (string custName in custNames)
            {
                Console.WriteLine($"Customer name: {custName}");
            }

            // Now we will define an array of ints
            int[] randNums = { 1, 4, 9, 2 };

            // We can pass an array as an argument to a function PrintArray that
            // we defined.
            PrintArray(randNums, "ForEach");

            // How to sort array?
            Array.Sort(randNums);

            // How to reverse array elements?
            Array.Reverse(randNums);

            // Get index of match in an array or return -1
            Console.WriteLine("1 at index: {0}", Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);

            // Copy part of an array to another array
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startIndex = 0;
            int length = 2;

            Array.Copy(srcArray, startIndex, destArray, startIndex, length);
            PrintArray(destArray, "Elements copied to destination array: ");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values from srcArray to anotherArray starting
            // at index 5 in destination.
            srcArray.CopyTo(anotherArray, 5);

            // Print element values of anotherArray
            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // ----------------- If-Else statements -----------------
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || !

            int age = 17;

            if (age >= 5 && age <= 7)
            {
                Console.WriteLine("Go to elementary school.");
            }
            else if (age > 7 && age < 13)
            {
                Console.WriteLine("Go to middle school.");
            }
            else if (age > 13 && age < 19)
            {
                Console.WriteLine("Go to high school.");
            }
            else
            {
                Console.WriteLine("Go to college.");
            }

            if (age < 14 || age > 67)
            {
                Console.WriteLine("You sholdn't work.");
            }

            Console.WriteLine("! true = " + (!true));

            // Ternary operator - it assigns 1st value if true, and 2nd value
            // otherwise.
            bool canDrive = age >= 16 ? true : false;

            // Switch is used when you have limited options. The only way to use
            // ranges is to stack the possible values.
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care.");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool.");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten.");
                    break;
                default:
                    Console.WriteLine("Go to another school.");
                    // You can also jump out of a switch with goto
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School.");

            // How to compare strings using Equals?
            string name2 = "Derek";
            string name3 = "Derek";

            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal.");
            }

            // ----------------- While loop -----------------
            // Use while loop when you want to execute some program as long as
            // a condition is true.
            // This while loop will print odd numbers between 1 and 10.
            int j = 1;
            while (j <= 10)
            {
                // % (Modulus) returns the remainder of a division. If it
                // returns 0 that means the value is even.
                if (j % 2 == 0)
                {
                    j++;

                    // Continue skips the rest of the code and starts execution
                    // back at the top of the while loop.
                    continue;
                }

                // Break jumps completely out of the loop.
                if (j == 9) break;

                Console.WriteLine(j);
                j++;
            }

            // ----------------- Do-While loop -----------------
            // Use do-while when you have to execute the code at least once.

            // Generate random number
            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11);
            //int numberGuessed = 0;
            //Console.WriteLine("Random Num: ", secretNumber);

            //do
            //{
            //    Console.Write("Enter a number between 1 and 10: ");
            //    // Use Convert to switch the string into an int. Other convert
            //    // options are ToBoolean, ToByte, ToChar, ToDecimal, ToInt64,
            //    // ToString. By using them you can convert any type to any other
            //    // type.
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());
            //}
            //while (secretNumber != numberGuessed);

            //Console.WriteLine("You guessed that the secret number was "
            //    + $"{secretNumber}.");

            // ----------------- Exception handling -----------------
            // We use exception handling to catch errors that could crash our
            // program.
            double num1 = 5;
            double num2 = 0;

            // Code that could case an error is surrounded by a try block.
            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            // We catch the error and warn the user rather than crash the
            // program.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");

                // Get additional info on the exception
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            // A default catch all for exceptions
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            // Finally block always runs and provides for clean up
            finally
            {
                Console.WriteLine("Cleaning up...");
            }

            // ----------------- String builder -----------------
            // Each time you change a string you are actually creating a new
            // string which is inefficient when you are working with large
            // blocks of text. StringBuilders actually change the text directly
            // in memory rather than make a copy of it.

            // Create a StringBuilder with a default size of 16 characters, but
            // it grows automatically.
            StringBuilder sb = new StringBuilder("Random text");

            // Create a StringBuilder with size of 256.
            StringBuilder sb2 = new StringBuilder("More stuff that "
                + "is very important", 256);

            // Get max size
            Console.WriteLine("Capacity: {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length: {0}", sb2.Length);

            // Add some text to StringBuilder
            sb2.AppendLine("\nMore important text...");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append defined culture format to a string
            string bestCustomer = "Bob Smith";
            sb2.AppendFormat(enUS, "Best customer: {0}", bestCustomer);

            // Output current StringBuilder text
            Console.WriteLine(sb2.ToString());

            // Replace a string inside a StringBuilder with a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a StringBuilder
            sb2.Clear();

            // Append some text to a StringBuilder
            sb2.Append("Random text");

            // Check if two StringBuilder objects are the same
            Console.WriteLine(sb.Equals(sb2));

            // Insert some text at index 11
            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());

            // Remove 7 characters starting at index 11
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());

            // ----------------- Functions / Methods -----------------
            // Functions are used to avoid the code duplication, to provide
            // better code organization and to allow for simulating various
            // systems.
            // How to define function/method?
            // <Access Specifier> <Return Type> <Method Name> (Parameters)
            // {
            //      <Function/Method Body>
            // }
            // Access Specifier determines whether the function can be called
            // from another class. There are three different specifiers:
            // public: Can be accessed from another class.
            // protected: Can be accessed by a class and derived classes.
            // private: Can't be accessed from another class.

            SayHello();

            // ----------------- Passing an argument by value -----------------

            // By default, values are passed into a method and not a reference
            // to the passed variables. This means that all changes made to
            // those values inside the function do not affect the variables
            // outside the function body.

            double x = 5;
            double y = 4;

            Console.WriteLine($"5 + 4 = {GetSum(x, y)}");

            // Even though the value of variable x has changed inside the
            // method, its value remains unchanged outside.
            Console.WriteLine("x = {0}", x);

            // ------------- Passing an argument by out parameter -------------

            // An argument may be passed to a method by out parameter as an
            // output variable, without assigning a value to it.

            int solution;

            // A parameter passed with out has its value assigned inside the
            // method.

            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}", solution);

            // ------------- Passing an argument by reference -------------

            // If an argument is passed by reference, all changes made to that
            // argument inside the method are also made outside the method.
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine($"Before Swap - num3: {num3}, num4: {num4}");

            Swap(ref num3, ref num4);

            Console.WriteLine($"After Swap - num3: {num3}, num4: {num4}");

            // ----------------- Params -----------------

            // How to pass arbitrary number of arguments to a function? This can
            // be done using params! An array may be used for the same purposes.

            Console.WriteLine($"1 + 2 + 3 = {GetSumMore(1, 2, 3)}");

            // ----------------- Named paramaters (arguments) -----------------

            // The argument values may be passed in any order if named
            // parameters are used.

            PrintInfo(zipCode: 15147, name: "Big Mike");
        }
    }
}