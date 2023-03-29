using System;

namespace WarriorsFightToTheDeath
{
	// Now we can define a warrior that has some magic abilities that make him
	// different from other warriors (e.g. teleporting). For that purpose we are
	// going to use ITeleports interface.
	class MagicWarrior : Warrior
	{
		// The bigger the number, the more likely the chance of successfully
		// teleporting (100 is a max value).
		int teleportChance = 0;

		// Add interface functionality.
		CanTeleport teleportType = new CanTeleport();

		// Define a constructor
		public MagicWarrior(string name = "Warrior", double health = 0,
			double attkMax = 0, double blockMax = 0, int teleportChance = 0)
			: base(name, health, attkMax, blockMax)
		{
			this.teleportChance = teleportChance;
		}

		// We will inherit all properties and methods from the Warrior class but
		// we are going to override method Block().
        public override double Block()
        {
			// Generate a random value from 1 to 100
			Random rnd = new Random();
			int rndDodge = rnd.Next(1, 100);

			// Teleporting will occurr only if random number is smaller than
			// given teleportChance. Else, the base class Block() method will
			// execute.
			if (rndDodge < this.teleportChance)
			{
				Console.WriteLine($"{Name} {teleportType.teleport()}.");
				return 10000;
			}
			else
			{
				return base.Block();
			}
        }
    }
}

