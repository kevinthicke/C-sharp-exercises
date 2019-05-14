using System;
using System.Collections.Generic;

namespace Exercise
{	
	class Canvas 
	{
		private static void drawShape(Shape shape)
		{
			var ShapeTypeNames = Enum.GetNames (typeof(ShapeType));

			foreach (var type in ShapeTypeNames) {
				if (shape.Type.ToString() == type)
					Console.WriteLine ("Draw a {0} with dimensions {1} x {2}", shape.Type, shape.Height, shape.Width);
			}
		}

		public static void drawShapes(List<Shape> shapes)
		{
			shapes.ForEach (shape => {
				drawShape(shape);	
			});
		}
	}
}
