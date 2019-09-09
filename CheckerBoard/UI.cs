using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
    public static class UI
    {
        public static void Print(ICheckersBoard board)
        {
            for (int i = 0; i < board.GetDimesionLength(0); i++)
            {
                for (int j = 0; j < board.GetDimesionLength(1); j++)
                {

                    Console.BackgroundColor = ConvertColors.ChangeCellColorIntoConsoleColor(board[i, j].Color);
                    if (board[i, j].CheckerOnCell != null)
                    {
                        Console.ForegroundColor = ConvertColors.ChangeCheckerColorIntoConsoleColor(board[i, j].CheckerOnCell.CheckerColor);
                    }
                    else
                    {
                        Console.ForegroundColor = Console.BackgroundColor;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
