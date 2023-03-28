using System;

// A class can support multiple interfaces.

namespace Interfaces
{
    public class Interfaces
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object.
            Vehicle buick = new Vehicle("Buick", 4, 160);

            // Check if Vehicle implements IDrivable.
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} cannot be driven!");
            }

            Console.ReadKey();
        }
    }
}