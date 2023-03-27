using System;

namespace ClassesAndObjects
{
    class Program
    {
        // ------------------ Structs ------------------

        // A struct is a user-defined type that contain multiple fields and
        // methods.
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }

        static void Main(string[] args)
        {
            // Create a Rectangle object rect1
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine($"Area of rect1 is: {rect1.Area()}");


            // Use a constructor to create a Rectangle object rect2
            Rectangle rect2 = new Rectangle(100, 40);
            // If we assign one object to another, we are setting the values
            // and not creating a reference.
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine($"rect2.length: {rect2.length}\n"
                + $"rect1.length: {rect1.length}");

            // ------------------ Object-Oriented Programming ------------------

            // A class models a real world objects by defining their attributes
            // (fields) and capabilities (methods). The same may be achieved by
            // using structs, but it is not possible to inherit fields and
            // methods from one struct to another. By using classes, it is
            // possible to inherit from a class and create more specific
            // subclass types.

            // Create an Animal object and assign its field values.
            Animal fox = new Animal() { name = "Red", sound = "Raaw" };
            // Call the static method.
            Console.WriteLine($"Number of animals: {Animal.GetNumAnimals()}");

            Console.WriteLine($"Area of Rectangle: "
                + $"{ShapeMath.GetArea("rectangle", 5, 6)}");
        }
    }
}