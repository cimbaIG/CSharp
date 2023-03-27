using System;

namespace ClassesAndObjects
{
	class Animal
	{
		// Attributes (fields) that all Animals have. Public keyword means that
		// object field value can be changed after an object has been created.
		public string name;
		public string sound;
		// Static fields and methods belong to the class. A static field has the
		// same value for all objects of the Animal type.
        static int numOfAnimals = 0;

        // --------------------- Constructors ---------------------

		// A constructor sets default values for fields when an object is
		// created.

		// A default constructor does not take any parameter.
        public Animal()
		{
			name = "No Name";
			sound = "No Sound";
			numOfAnimals++;
		}

		// Additional constructors may be created but it is not necessary as we
		// created default constructor.
		public Animal(string name = "No Name")
		{
			// this keyword refers to this objects name instead of the name
			// passed into the constructor.
			this.name = name;
			this.sound = "No Sound";
			numOfAnimals++;
		}

		public Animal(string name = "No Name", string sound = "No Sound")
		{
			this.name = name;
			this.sound = sound;
			numOfAnimals++;
		}

        // --------------------- Methods ---------------------

		// Capabilities (methods) that all Animals objects have.

		public void MakeSound()
		{
			Console.WriteLine($"{name} says {sound}.");
		}

		public static int GetNumAnimals()
		{
			return numOfAnimals;
		}
    }
}

