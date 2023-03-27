using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal micko = new Animal()
            {
                Name = "Micko",
                Sound = "Meow"
            };

            Dog lora = new Dog()
            {
                Name = "Lora",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            // Demonstrate changing the protected field sound
            lora.Sound = "Woooooof";

            micko.MakeSound();
            lora.MakeSound();

            // Define the AnimalIDInfo
            micko.SetAnimalIDInfo(12345, "Mihael Cindori");
            lora.SetAnimalIDInfo(12345, "Valentina Bokun");

            micko.GetAnimalIDInfo();

            // Test the inner class
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine($"Is my animal healthy: {getHealth.HealthyWeight(11, 46)}");

            // We can define two Animal objects but have one actually be a Dog
            // type.
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woooofff",
                Sound2 = "Geeerrrrr"
            };

            // The problem is that if we want to call a function in Animal, it
            // will not call the overridden method in Dog unless the method that
            // might be overridden is marked virtual.
            spot.MakeSound();

            // This is an example of how Polymorphism allows a subclass to
            // override a method in the super class. Even if the subclass is
            // defined as the super class type, the correct method will be
            // called.

            Console.ReadKey();
        }
    }
}

