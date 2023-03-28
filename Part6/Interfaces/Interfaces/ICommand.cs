using System;

namespace Interfaces
{
	interface ICommand
	{
		// We can model what happens when a button is pressed (e.g. the power
		// button). By breaking everything down, we can add an infinite amount
		// of flexibility.
		void Execute();
		void Undo();
	}
}

