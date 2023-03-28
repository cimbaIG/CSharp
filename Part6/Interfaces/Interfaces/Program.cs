using System;

// A class can support multiple interfaces.

namespace Interfaces
{
    public class Interfaces
    {
        static void Main(string[] args)
        {
            // Create a Vehicle object.
            Vehicle buick = new Vehicle("Buick", 4, 160);

            // Check if Vehicle implements IDrivable.
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} cannot be driven!");
            }

            // Now we are modelling the act of picking up the remote controler,
            // aiming it at the TV, clicking the power button and then watching
            // as the TV turns on and off.

            // Pick up the TV remote.
            IElectronicDevice TV = TVRemote.GetDevice();

            // Create the power button.
            PowerButton powBut = new PowerButton(TV);

            // Turn the TV on and off with each press.
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();

            Console.ReadKey();
        }
    }
}