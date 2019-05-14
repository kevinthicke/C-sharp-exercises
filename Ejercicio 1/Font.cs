using System;
using System.Collections.Generic;

namespace inherietance
{

	class Font {

		private string _style = "normal";
		private string _size = "14pt";
	
		private bool isFontStyle(string style)
		{
			List<string> allowedStyles = new List<string> (){ "normal", "bold", "italic", "underlined", "classic" };

			return allowedStyles.Contains (style);
		}

		private bool isFontSize(string size)
		{
			List<string> allowedSizes = new List<string> (){ "12pt", "14pt", "17pt", "22pt" };

			return allowedSizes.Contains (size);
		}

		public string getStyle () => this._style;
		public string getSize () => this._size;

		public Font() {}

		public Font(string style, string size)
		{
			if (isFontStyle (style) & isFontSize (size)) {
				this._style = style;
				this._size = size;
			} else {
				Console.WriteLine ("Style or size not supported. Created new Font('normal', '14pt')");
			}
		}
	}
	
}
