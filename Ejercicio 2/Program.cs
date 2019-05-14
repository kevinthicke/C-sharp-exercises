using System;
using System.Collections.Generic;

namespace Exercise
{	
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Shape> shapes = new List<Shape> ();

			shapes.Add (new Circle {
				Height = 1.12f,
				Width = 3,
				Position = new Position (2, 3)
			});

			shapes.Add (new Rectangle {
				Height = 1.13f,
				Width = 5,
				Position = new Position (5, 3)
			});

			shapes.Add (new Shape {
				Height = 8.3f,
				Width = 3.2f
			});

			Canvas.drawShapes (shapes);

		}

	}
}
