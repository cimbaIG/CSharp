using System;

namespace ClassesAndObjects
{
	class Rectangle : Shape
	{
		public double Length { get; set; }
		public double Width { get; set; }

		public Rectangle(double length, double width)
		{
			Name = "Rectangle";
			Length = length;
			Width = width;
		}

		public override double Area()
		{
			return Length * Width;
		}

        // The base-class GetInfo() method may be overriden using the override
        // keyword.
        public override void GetInfo()
		{
            // Execute the GetInfo() method define inside the base class (Shape
            // class).
            base.GetInfo();
			Console.WriteLine($"It has a length of {Length} " +
				$"and width of {Width}.");
		}
	}
}

