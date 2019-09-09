using System;
using System.Linq;


namespace CheckerBoard
{

	public class CheckersBoard : ICheckersBoard, ICloneable
    {
		#region private

		private readonly int height;

		private readonly int width;

		private Cell[,] cellArray;

		#endregion

        public Cell this[int height,int width]
        {
            get
            {
                if(height < this.height && width < this.width)
                {
                    return cellArray[height, width];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (height < this.height && width < this.width)
                {
                    cellArray[height, width] = value;
                }
            }
        }

		public CheckersBoard(int height, int width)
		{
			this.height = height;
			this.width = width;
			cellArray = new Cell[height, width];
		}

        public int NumberOfSelectedCheckers(CheckerColor color)
		{
			int counter = 0;
			for(int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if((cellArray[i,j].CheckerOnCell != null) && (cellArray[i, j].CheckerOnCell.CheckerColor == color))
					{
						counter++;
					}
				}
			}
			return counter;
		}

		public override string ToString()
		{
			return String.Format("Height = {0}, width = {1}, number of black checkers = {2}, number of white checkers = {3}", 
			height, width, NumberOfSelectedCheckers(CheckerColor.Black), NumberOfSelectedCheckers(CheckerColor.White));
		}

        public int GetDimesionLength(int dimension)
        {
            if(dimension > 1)
            {
                return 0;
            }
            return cellArray.GetLength(dimension);
        }

        public object Clone()
        {
            CheckersBoard newBoard = new CheckersBoard(this.height, this.width);
            for(int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newBoard[i, j] = (Cell)cellArray[i, j].Clone();
                }
            }

            return newBoard;
        }
    }
}
