using System;

namespace WarriorsFightToTheDeath
{
	class Warrior
	{
		// Warrior class properties
		public string Name { get; set; }
		public double Health { get; set; }
		public double AttkMax { get; set; }
		public double BlockMax { get; set; }

		// Always create a single Random instance and reuse it or you will get
		// the same value over and over.
		Random rnd = new Random();

		// Constructor initializes the warrior object
		public Warrior(string name = "Warrior", double health = 0,
			double attkMax = 0, double blockMax= 0)
		{
			Name = name;
			Health = health;
			AttkMax = attkMax;
			BlockMax = blockMax;
		}

		// Generate a random attack value from 1 to the warriors maximum attack
		// value.
		public double Attack()
		{
			return rnd.Next(1, (int)AttkMax);
		}

		// Generate a random block value from 1 to the warriors maximum block.
        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}

