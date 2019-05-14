using System;
using System.Collections.Generic;

namespace Exercise
{
	class Shape {
		
		protected float _height;
		protected float _width;
		public Position Position { get; set; }

		public float Height {
			get { return this._height; }
			set {
				if (value <= 0)
					throw new Exception ("height must be greater than zero");
				this._height = value;
			}
		}

		public float Width {
			get { return this._width; }
			set {
				if (value < 0)
					throw new Exception ("width must be greater than zero");
				this._width = value;
			}
		}

		public virtual void Draw()
		{
			Console.WriteLine ("Draw a shape with dimensions {0} x {1}", this._height, this._width);
		}
	}

	class Circle: Shape 
	{
		public override void Draw ()
		{
			Console.WriteLine ("Draw a circle with dimensions {0} x {1}", this._height, this._width);
		}
	}

	class Rectangle: Shape
	{
		public override void Draw ()
		{
			Console.WriteLine ("Draw a circle with dimensions {0} x {1}", this._height, this._width);
		}
	}

}
