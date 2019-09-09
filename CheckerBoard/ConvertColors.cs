using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
    public static class ConvertColors
    {
        public static ConsoleColor ChangeCellColorIntoConsoleColor(CellColor color)
        {
            if (color == CellColor.White)
            {
                return ConsoleColor.White;
            }
            else
            {
                return ConsoleColor.Red;
            }
        }

        public static ConsoleColor ChangeCheckerColorIntoConsoleColor(CheckerColor color)
        {
            if (color == CheckerColor.White)
            {
                return ConsoleColor.White;
            }
            else
            {
                return ConsoleColor.Black;
            }
        }
    }
}
