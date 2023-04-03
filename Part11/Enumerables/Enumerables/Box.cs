using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Enumerables
{
    class Box
    {
        // Properties
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        // Assign values length = 1, width = 1, breadth = 1 when default
        // constructor is instantiated.
        public Box()
            : this(1, 1, 1) { }

        // Constructor
        public Box(double length, double width, double breadh)
        {
            Length = length;
            Width = width;
            Breadth = breadh;
        }

        // Through operator overloading users can interact with their custom
        // objects in interesting ways. One can overload +, -, *, /, %, !,
        // ==, !=, >, <,>=, <=, ++ and --.

        // Overload + operator
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return box;
        }

        // Overload - operator
        public static Box operator-(Box box1, Box box2) 
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return box;
        }

        // Overload == operator
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        // Overload != operator
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                box1.Breadth != box2.Breadth)
            {
                return true;
            }
            return false;
        }
        
        // Override ToString() method to define how our object is converted
        // into string.
        public override string ToString()
        {
            return String.Format("Box with Height: {0}, Width: {1} and Breadth: {2}",
                Length, Width, Breadth);
        }

        // We can convert from a Box into an int!
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        // Convert from an int into a Box!
        public static implicit operator Box(int i)
        {
            // Return a box object with the lengths all set to the int passed!
            return new Box(i, i, i);
        }
    }
}
