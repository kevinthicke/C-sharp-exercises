using System;
using System.Collections.Generic;

namespace Exercise
{	
	class MainClass
	{
		public static void Main (string[] args)
		{
			var shape1 = new Shape ();
			shape1.Height = 1.12f;
			shape1.Width = 3;
			shape1.Position = new Position (2, 3);
			shape1.Type = ShapeType.Circle;


			var shape2 = new Shape ();
			shape2.Height = 1.13f;
			shape2.Width = 5;
			shape2.Position = new Position (5, 3);
			shape2.Type = ShapeType.Rectangle;

			Canvas.drawShapes (new List<Shape>{ shape1, shape2 });

		}

	}
}
