using System;

// In this lecture are covered the abstract classes, abstract methods, base
// classes, is and as keywords, casting and polymorphism.

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // All shapes can be stored to the Shape array as long as it
            // contains subclasses of class Shape.
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            // Cycle through all the shapes in shapes array and print shape area
            // values.
            foreach (Shape s in shapes)
            {
                // Call the overridden method.
                s.GetInfo();

                Console.WriteLine("{0} Area: {1:f2}",
                    s.Name, s.Area());

                // The "as" keyword may be used to check if an object is of a
                // specific type.
                Circle testCirc = s as Circle;

                if (testCirc == null)
                {
                    Console.WriteLine("This is not a Circle.");
                }

                // We can also use "is" keyword to check the data type.
                if (s is Circle)
                {
                    Console.WriteLine("This is not a Rectangle.");
                }
            }

            // We can store any class as a base class and call the subclass
            // methods, even if they do not exist in the base class. But in that
            // case we have to use casting!
            object circ1 = new Circle(4);

            // Example of casting...
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} Area is {1:f2}.",
                circ2.Name, circ2.Area());

            Console.ReadKey();
        }
    }
}