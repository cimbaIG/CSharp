using System;

namespace WarriorsFightToTheDeath
{
    public class WarriorsFightToTheDeath
    {
        // What do we want to achieve?
        /*
        Thor Attacks Hulk and Deals 74 Damage
        Maximus Has 69 Health
 
        Hulk Attacks Thor and Deals 6 Damage
        Bob Has 6 Health
 
        Thor Attacks Hulk and Deals 48 Damage
        Maximus Has 21 Health
 
        Hulk Attacks Thor and Deals 48 Damage
        Bob Has -42 Health
 
        Thor has Died and Hulk is Victorious
 
        Game Over
        */
        static void Main(string[] args)
        {
            // Thor is more powerful so let's treat him that way
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            // Loki will however have magic abilities
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);

            Battle.StartFight(thor, loki);

            Console.ReadKey();
        }
    }
}

