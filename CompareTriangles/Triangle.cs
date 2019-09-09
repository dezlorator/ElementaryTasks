using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
	class Triangle
	{
        #region private
		private double _firstSide;
		private double _secondSide;
		private double _thirdSide;
		#endregion

		#region property
		public double FirstSide

		{
			get
			{
				return _firstSide;
			}
			set
			{
				if(value > 0)
				{
					_firstSide = value;
				}
			}
		}

		public double SecondSide
		{
			get
			{
				return _secondSide;
			}
			set
			{
				if (value > 0)
				{
					_secondSide = value;
				}
			}
		}

		public double ThirdSide
		{
			get
			{
				return _thirdSide;
			}
			set
			{
				if (value > 0)
				{
					_thirdSide = value;
				}
			}
		}

		public double HalfPerimeter
		{
			get
			{
				return FirstSide + SecondSide + ThirdSide;
			}
		}

		public double Square
		{
			get
			{
				return Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstSide) * (HalfPerimeter - SecondSide) * (HalfPerimeter - ThirdSide));
			}
		}

        public string Name { get; set; }

		#endregion

		public Triangle(string name, double firstSide, double secondSide, double thirdSide)
		{
			this.Name = name;
			FirstSide = firstSide;
			SecondSide = secondSide;
			ThirdSide = thirdSide;
		}

		public static bool IsTriangleExist(Triangle triangle)
		{
			return ((triangle.FirstSide < triangle.SecondSide + triangle.ThirdSide) && (triangle.SecondSide < triangle.FirstSide + triangle.ThirdSide) &&
				   (triangle.ThirdSide < triangle.SecondSide + triangle.FirstSide));
		}

        public override string ToString()
        {
            return string.Format("[{0}], {1} cm", Name, Square);
        }
    }
}
