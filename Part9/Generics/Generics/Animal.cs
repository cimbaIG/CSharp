using System;
using System.Collections.Generic;

namespace Generics
{
	class Animal
	{
		public string Name { get; set; }

		public Animal(string name = "No Name")
		{
			Name = name;
		}

		// Generic is usually used when we need many overloaded methods that
		// differ only by their parameters.
		public static void GetSum<T>(ref T num1, ref T num2)
		{
			double dblX = Convert.ToDouble(num1);
			double dblY = Convert.ToDouble(num2);

			Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
		}
	}
}

