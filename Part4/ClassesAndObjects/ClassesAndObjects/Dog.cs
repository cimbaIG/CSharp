using System;

namespace ClassesAndObjects
{
    // When we inherit from another class, we get all of its fields and
    // methods. It is not possible to inherit from multiple classes.
    class Dog : Animal
	{
        // ----------------------- Properties -----------------------

        // We can define additional properties or fields in the child class.
        public string Sound2 { get; set; } = "Grrrrr";

        // ----------------------- Constructors -----------------------

        // Create constructor based upon the base constructor inherited from the
        // base class. Initialize the Sound2 with sound2 value.
        public Dog(string name = "No Name",
			string sound = "No Sound",
			string sound2 = "No Sound 2")
			: base(name, sound)
		{
			Sound2 = sound2;
		}

        // ----------------------- Methods -----------------------

        // Add override keyword so that correct method is called when a Dog
        // object is created as an Animal type.
        public override void MakeSound()
        {
			Console.WriteLine($"{Name} says {Sound} and {Sound2}.");
        }

        // You can overwrite methods by adding new keyword.
        /*
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        */
    }
}

