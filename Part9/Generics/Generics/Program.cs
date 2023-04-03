using System;
using System.Collections.Generic;

// In this lecture we focus on generic collections, generic methods, generic
// structs and delegates.

namespace Generics
{
    public class Generics
    {
        static void Main(string[] args)
        {
            // Generic collections are type safe and provide performance
            // benefits. We can define the data type when defining the generic.
            // This is a dynamically resizing collection.
            List<Animal> animalList = new List<Animal>();

            // We can also define a list of standard types like int.
            List<int> numList = new List<int>();
            // Add an int to the list.
            numList.Add(24);

            // Add some Animal objects to the list
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            // Insert Animal object to the list at index 1
            animalList.Insert(1, new Animal() { Name = "Steve" });
            // Remove the Animal positioned at index 1 from the list
            animalList.RemoveAt(1);

            // Get the total number of Animal objects in the list
            Console.WriteLine("Num of Animals: {0}",
                animalList.Count());

            // Cycle through all Animal objects in the list and print their
            // names.
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            // We can also use Stack<T>, Queue<T>, Dictionary<TKey, TValue>.

            // Generic methods: We can use the type parameter <int> id it can
            // be inferred from the parameters passed. This cannot be done if
            // there are no parameters.
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            // It works for string data type as well.
            string strX = "5", strY = "4";
            Animal.GetSum<string>(ref strX, ref strY);

            // Use the generic struct.
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());

            // Create delegate objects
            Arithmetic add, sub, addSub;

            // Assign just the Add method
            add = new Arithmetic(Add);

            // Assign just the Subtract method
            sub = new Arithmetic(Subtract);

            // Assign Add and Sub
            addSub = add + sub

            // We can also subtract a method
            // sub = addSub - add;

            // Print out the results
            Console.WriteLine($"Add {6} and {10}");
            add(6, 10);

            // Call both methods
            Console.WriteLine($"Add & Subtract {10} & {4}");
            addSub(10, 4);

            Console.ReadKey();
        }
    }

    // We can also create generic structs and generic classes in the same way.
    public struct Rectangle<T>
    {
        // Generic fields
        private T width;
        private T length;

        // Generic properties
        public T Width
        {
            get { return width; }
            set { width = value; }
        }

        public T Length
        {
            get { return length; }
            set { length = value; }
        }

        // Generic constructor
        public Rectangle(T w, T l)
        {
            width = w;
            length = l;
        }

        public string GetArea()
        {
            double dblWidth = Convert.ToDouble(Width);
            double dblLength = Convert.ToDouble(Length);

            return string.Format($"{Width} * {Length} = "
                + $"{dblWidth * dblLength}");
        }
    }

    // Define a delegate type that performs arithmetic. It defines the return
    // type and the types for attributes.
    public delegate void Arithmetic(double x, double y);

    // Methods that will be assigned to the delegate

    public static void Add(double x, double y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public static void Subtract(double x, double y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }
}