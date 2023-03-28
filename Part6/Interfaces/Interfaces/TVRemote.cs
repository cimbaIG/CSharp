using System;

namespace Interfaces
{
	class TVRemote
	{
		// Now we are modelling the action of picking tv remote controler up
		// with our hand.
		public static IElectronicDevice GetDevice()
		{
			return new Television();
		}
	}
}

