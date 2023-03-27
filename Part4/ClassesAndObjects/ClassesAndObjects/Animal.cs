using System;

namespace ClassesAndObjects
{
	class Animal
	{
		private string name;

		// A protected field can be changed by a subclass directly.
		protected string sound;

		// Inheritance has a "is-a" relationship, while an aggregation or
		// delegate represents a "has-a" relationship (just like we have here
		// with the AnimalIDInfo object).
		protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

		public void SetAnimalIDInfo(int idNum, string owner)
		{
			animalIDInfo.IDNum = idNum;
			animalIDInfo.Owner = owner;
		}

		public void GetAnimalIDInfo()
		{
			Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and "
				+ $"is owned by {animalIDInfo.Owner}.");
		}

		// Virtual keyword was added because we want this method to be
		// overridden by subclasses. But we have to add override keyword to the
		// method in the subclass.
		public virtual void MakeSound()
		{
			Console.WriteLine($"{Name} says {sound}.");
		}

		public Animal() : this("No Name", "No Sound") { }

		public Animal(string name) : this(name, "No Sound") { }

		public Animal(string name, string sound)
		{
			Name = name;
			Sound = sound;
		}

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
			}
		}

		public string Sound
		{
			get { return sound; }
			set
			{
				if (value.Length > 10)
				{
					sound = "New Sound";
				}
				sound = value;
			}
		}

		// We can create inner classes that are normally helper classes for the
		// outer class because it can access private members of the outer class.
		public class AnimalHealth
		{
			public bool HealthyWeight(double height, double weight)
			{
				double calc = height / weight;

				if ((calc >= .18) && (calc <= .27))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
    }
}

