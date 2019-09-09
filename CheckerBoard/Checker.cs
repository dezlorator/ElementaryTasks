using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
	public class Checker : ICloneable
	{

		#region private
		private int _x;

		private int _y;

		#endregion

		#region public

		private CheckerColor _checkerColor;

		#endregion

		#region properties
		public int X
		{
			get { return _x; }
			set
			{
				if(value>=0)
				{
					_x = value;
				}
			}
		}

		public int Y
		{
			get { return _y; }
			set
			{
				if (value >= 0)
				{
					_y = value;
				}
			}
		}

		public CheckerColor CheckerColor
		{
			get { return _checkerColor; }
			set
			{
				if (value == CheckerColor.White || value == CheckerColor.Black)
				{
					_checkerColor = value;
				}
			}
		}
		#endregion

		public Checker(int x, int y, CheckerColor checkerColor)
		{
			X = x;
			Y = y;
			CheckerColor = checkerColor;
		}

		public object Clone()
		{
			return new Checker(X, Y, CheckerColor);
		}

		public override string ToString()
		{
			return String.Format("Checker coordinates X = {0}, Y = {1}, checker color - ", X, Y, CheckerColor.ToString());
		}
	}
}
