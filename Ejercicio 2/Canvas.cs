using System;
using System.Collections.Generic;

namespace Exercise
{	
	class Canvas 
	{
		public static void drawShapes(List<Shape> shapes)
		{
			shapes.ForEach (shape => {
				shape.Draw();
			});
		}
	}
}
