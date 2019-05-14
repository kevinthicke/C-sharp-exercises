using System;
using System.Collections.Generic;

namespace Exercise
{
	enum ShapeType {
		Circle,
		Rectangle,
		Triangle
	}

	class Shape {
		
		private float _height;
		private float _width;
		public Position Position { get; set; }
		public ShapeType Type { get; set; }

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
	}
	
}
