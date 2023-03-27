using System;

namespace ClassesAndObjects
{
	// What is covered by this lecture?
	// Public, private, protected, constants, read-only fields, constructors,
	// setters, getters, properties and more on static.

	class Animal
	{
		// Define fields that are protected with private keyword.
		// Private fields can only be accessed by methods in the class and they
		// are not accessible by subclasses.
		// Protected fields can only be accessed by methods in the class and by
		// its subclasses.
		private string name;
		private string sound;

		// Define a constant.
		public const string SHELTER = "Mihael's home for animals.";

		// Define a read-only fields that are set at runtime in constructors,
		// but they cannot be changed.
		public readonly int idNum;

        // You can also define static properties
        public static int numOfAnimals = 0;

        // -------------------------- Constructors --------------------------

        // Default constructor
        public Animal() : this("No Name", "No Sound") { }

		// Constructor called if only name is passed. Keyword this passes the
		// parameters to the next constructor.
		public Animal(string name) : this(name, "No Sound") { }

		// Constructor that receives parameters
		public Animal(string name, string sound)
		{
			SetName(name);
			Sound = sound;

			// Implement the number of animals property.
			numOfAnimals = 1;

			// Define the read-only value which is the same for all Animals
			Random rnd = new Random();
			idNum = rnd.Next(1, 2147483640);
        }

        // ----------------------- Getters and Setters -----------------------

		// Setters (mutators) protect the fields from receiving bad data.
		public void SetName(string name)
		{
			// Any checks if any character in the string is a number and if so
			// returns true. Since we will not allow numbers we will protect our
			// data.
			if (!name.Any(char.IsDigit))
			{
				this.name = name;
			}
			else
			{
				// We have this duplicated code because everything is not a
				// property.
				this.name = "No Name";
				Console.WriteLine("Name can't contain numbers.");
			}
		}

		// Getters (accessors) can provide output aside from the value stored.
		public string GetName()
		{
			return name;
		}

		// The preferred way to define getters and setters is through properties
		public string Sound
		{
			get { return sound; }
			set
			{
				// Value is assigned the value passed in
				if (value.Length > 10)
				{
					sound = "No Sound";
					Console.WriteLine("Sound is too long.");
				}
				else
				{
					sound = value;
				}
			}
		}

		// You can have the getters and setters generated for you like this and
		// also set the default value.
		public string Owner { get; set; } = "No Owner";

		public static int NumOfAnimals
		{
			get { return numOfAnimals; }
			set { numOfAnimals += value; }
		}
    }
}

