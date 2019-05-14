using System;
using System.Collections.Generic;

namespace Exercise
{

	class Position {
		
		private readonly float _x;
		private readonly float _y;

		public Position(float x, float y)
		{
			this._x = x;
			this._y = y;
		}

		public float[] getPosition () => new float[] { this._x, this._y};
	}
	
}
