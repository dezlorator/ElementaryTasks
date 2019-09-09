using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
	public class FillCkeckersBoard : IFillCheckersBoard
	{

        #region

        private ICheckersBoard checkerBoard;

		#endregion

		public FillCkeckersBoard(ICheckersBoard board)
		{
            checkerBoard = board;
        }

		public ICheckersBoard GetFilledBoard()
		{
			ColorCell(checkerBoard);
			GetCheckrersOnBoard(checkerBoard);

			return checkerBoard;
		}

		private ICheckersBoard ColorCell(ICheckersBoard board)
		{
			for (int i = 0; i < board.GetDimesionLength(0); i++)
			{
				for (int j = 0; j < board.GetDimesionLength(1); j++)
				{
					if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
					{
						board[i, j] = new Cell(CellColor.Red);
					}
					else
					{
						board[i, j] = new Cell(CellColor.White);
					}
				}
			}

			return board;
		}

		private ICheckersBoard GetCheckrersOnBoard(ICheckersBoard board)
		{
			int numberOfCellsBetweenCheckers = 3;
			if (board.GetDimesionLength(0) % 2 == 0)
			{
				numberOfCellsBetweenCheckers = 2;
			}

			for (int i = (board.GetDimesionLength(0) - numberOfCellsBetweenCheckers) / 2 - 1; i >= 0; i--)
			{
				for (int j = 0; j < board.GetDimesionLength(1); j++)
				{
					if (board[i, j].Color == CellColor.Red)
					{
						board[i, j].CheckerOnCell = new Checker(i, j, CheckerColor.White);
					}
				}
			}

			for (int i = board.GetDimesionLength(0) - (board.GetDimesionLength(0) - numberOfCellsBetweenCheckers) / 2; 
				i < board.GetDimesionLength(0); i++)
			{
				for (int j = 0; j < board.GetDimesionLength(1); j++)
				{
					if (board[i, j].Color == CellColor.Red)
					{
						board[i, j].CheckerOnCell = new Checker(i, j, CheckerColor.Black);
					}
				}
			}

			return board;
		}
	}
}
