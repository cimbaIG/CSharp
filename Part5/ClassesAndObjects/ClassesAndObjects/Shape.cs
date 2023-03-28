using System;

// If we want to create a class that we do not want to be instantiated, we
// define this class as an abstract class.
namespace ClassesAndObjects
{
	abstract class Shape
	{
		// Define Name property
		public string Name { get; set; }

		// A non-abstract methods may also be defined in an abstract class.
		public virtual void GetInfo()
		{
			Console.WriteLine($"This is a {Name}.");
		}

		// As we want subclasses to override Area() method, we define this
		// method as an abstract method. The abstract methods may only be
		// defined inside abstract classes.
		public abstract double Area();
	}
}

