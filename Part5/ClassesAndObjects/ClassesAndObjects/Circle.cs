using System;

namespace ClassesAndObjects
{
	class Circle : Shape
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Name = "Circle";
			Radius = radius;
		}

        public override double Area()
        {
			return Math.PI * (Math.Pow(Radius, 2.0));
        }

		// The base-class GetInfo() method may be overriden using the override
		// keyword.
        public override void GetInfo()
        {
			// Execute the GetInfo() method define inside the base class (Shape
			// class).
            base.GetInfo();
			Console.WriteLine($"It has a radius of {Radius}.");
        }
    }
}

