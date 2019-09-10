using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
	public class Validator
	{
		#region private
		private string[] args;
		private string WRONG_NUMBER_OF_ARGS = "You should write two integer arguments";
		private string WRONG_ARGS_TYPE = "Your arguments should be an integers";
		private string WRONG_BOARD_SIZE = "Arguments must be bigger than zero";
		#endregion

		#region public
		public static string infoAboutProgramm;
		#endregion

		public Validator(string[] commandLineArguments)
		{
			infoAboutProgramm = "This programm draws checker board in console.\nIt has 2 arguments - height and width, which must be an integers";
			args = commandLineArguments;
		}

		public bool CheckCommandArguments()
		{
			if (args.Length == 0)
			{
				Console.WriteLine(infoAboutProgramm);

				return false;
			}
			int height;
			int width;
			try
			{
				height = Convert.ToInt32(args[0]);
				width = Convert.ToInt32(args[1]);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine(WRONG_NUMBER_OF_ARGS);
				Console.WriteLine(infoAboutProgramm);

				return false;
			}
			catch (FormatException)
			{
				Console.WriteLine(WRONG_ARGS_TYPE);
				Console.WriteLine(infoAboutProgramm);

				return false;
			}
			if (height <= 0 || width <= 0)
			{
				Console.WriteLine(WRONG_BOARD_SIZE);
				Console.WriteLine(infoAboutProgramm);

				return false;
			}

			return true;
		}

	}
}
