using System;

namespace Interfaces
{
	// An interface is a class with nothing but the abstract methods. Interfaces
	// are used to represent a contract an object may decide to support.
	// Interfaces commonly have names that are adjectives because adjectives
	// modify nouns (Objects). They also describe abstract things.
	// It is common practice to prefix interface with capital letter I.
	interface IDrivable
	{
		// Interfaces can have properties.
		int Wheels { get; set; }
		double Speed { get; set; }

		// Classes that inherit an interface must fulfill the contract and
		// implement every abstract method defined inside the interface.
		void Move();
		void Stop();
	}
}

