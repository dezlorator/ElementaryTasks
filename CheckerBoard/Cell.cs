using System;
namespace CheckerBoard
{
	public class Cell : ICloneable
	{

		#region private

		private CellColor color;

		#endregion

		#region properties
		public CellColor Color
		{
			get { return color; }
			set
			{
				if(value == CellColor.White || value == CellColor.Red)
				{
					color = value;
				}
			}
		}

		public Checker CheckerOnCell { get; set; }
		#endregion

		public Cell(CellColor cellColor)
		{
			Color = cellColor;
		}

		public override string ToString()
		{
			return String.Format("Cell color - {0}", Color.ToString());
		}

        public object Clone()
        {
            Cell newSell = new Cell(color);
            newSell.CheckerOnCell = (Checker)this.CheckerOnCell.Clone();
            return newSell;
        }
    }
}
