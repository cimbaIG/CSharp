using System;

namespace Interfaces
{
	// With interfaces we can create very flexible systems. Here are modelled
	// generic electronic devices like TVs and Radios, as well as remotes that
	// control them (including the buttons on remotes).
	interface IElectronicDevice
	{
		// We want that each electronic device has these capabilities.
		void On();
		void Off();
		void VolumeUp();
		void VolumeDown();
	}
}

