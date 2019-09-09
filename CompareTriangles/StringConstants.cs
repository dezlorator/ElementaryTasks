using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriangles
{
    static class StringConstants
    {
        #region public

        public static string WELCOME_STRING = "Hello there. This programm takes triangles and output them in decreasing order";

        public static string INFO_ABOUT_INPUT = "You should print values in such order - triangle name, first, second, third side";

        public static string INFO_ABOUT_TYPES = "You should print string name and float sides";

        public static string FIRST_STRING_OF_OUTPUT = "============= Triangles list: ===============";

        public static string IF_WANT_TO_CONTINUE = "If you want to continue press y or yes";

        #region ErrorMessages

        public static string WRITTEN_NOTHING = "You wrote nothing. Please, try again";

        public static string WRONG_NUMBER_OF_ARGUMENTS = "You wrote wrong number of arguments. Please, try again";

        public static string WRONG_TYPE_OF_SIDE = "You should write rigth arguments type. Please, try again";

        public static string WRONG_VALUE_OF_SIDE = "Side value should be bigger than 0";

        #endregion

        #endregion

    }
}
