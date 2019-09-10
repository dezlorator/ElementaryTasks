using System;
using ArgumentsValidator;

namespace CheckerBoard
{
	public class Program
	{
		static void Main(string[] args)
		{
            Validator val = new Validator(args);
            if (val.CheckCommandArguments())
            {
                ICheckersBoard board = new CheckersBoard(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                IFillCheckersBoard fillBoard = new FillCkeckersBoard(board);
                board = fillBoard.GetFilledBoard();
                UI.Print(board);
                Console.WriteLine(board.ToString());
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
	}
}
