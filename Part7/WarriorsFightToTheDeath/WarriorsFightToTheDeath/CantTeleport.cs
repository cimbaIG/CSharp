using System;

namespace WarriorsFightToTheDeath
{
    class CantTeleport : ITeleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}

