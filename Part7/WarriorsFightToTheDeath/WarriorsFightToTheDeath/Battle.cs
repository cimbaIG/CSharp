using System;

namespace WarriorsFightToTheDeath
{
	class Battle
	{
		// As this is a utility class, it makes sense to use only static methods

		// Start fight method takes two warrior objects as arguments
		public static void StartFight(Warrior warrior1, Warrior warrior2)
		{
			// Loop giving each Warrior a chance to attack and block each turn
			// until one of warriors dies
			while (true)
			{
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
			
		}

		// A method takes two Warrior object as arguments
		public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
		{
			// Calculate the value of one Warriors attack and another Warriors
			// block.
			double warAArrkAmt = warriorA.Attack();
			double warBBlkAmt = warriorB.Block();

			// Subtract block value from attack value to get damage that was
			// suffered by second warrior.
			double dmg2WarB = warAArrkAmt - warBBlkAmt;

			// If there was some damage, subtract that damage from the warriors
			// health.
			if (dmg2WarB > 0)
			{
				warriorB.Health = warriorB.Health - dmg2WarB;
			}
			else
			{
				dmg2WarB = 0;
			}

            // Print out info on who attacked who and for how much damage
            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and "
				+ $"deals {dmg2WarB} damage.");
            // Provide output on the change to health
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} "
				+ "health.\n");

			// Check if warriors health fell below zero. If so, print a "Game
			// Over" message and send response that will end the while loop.
			if (warriorB.Health <= 0)
			{
                Console.WriteLine($"{warriorB.Name} has died and "
					+ $"{warriorA.Name} is victorious.");

				return "Game Over";
            }
			else
			{
				return "Fight Again";
			}
        }
	}
}

