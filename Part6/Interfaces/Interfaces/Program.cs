﻿using System;

namespace Interfaces
{
    public class Interfaces
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

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