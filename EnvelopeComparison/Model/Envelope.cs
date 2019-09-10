using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
	public class Envelope
	{

        #region property

        public double Height { get; private set; }

        public double Width { get; private set; }

        #endregion

        public Envelope(double height, double width)
		{
            Height = height;
            Width = width;
		}

	}
}
