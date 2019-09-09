using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPatternItText
{
    static class StringConstants
    {
        #region public

        public static string WELCOME_STRING = "Hello there. This programm takes file and search pattern on it.\n " +
                                                "If you want to swap print string, which you want to swap as third argument";

        public static string INFO_ABOUT_INPUT = "You should print values in such order - file path, pattern and string to swap pattern if you want";

        #region ErrorMessages

        public static string WRITTEN_NOTHING = "You wrote nothing. Please, try again";

        public static string WRONG_NUMBER_OF_ARGUMENTS = "You wrote wrong number of arguments. Please, try again";

        public static string FILE_NOT_FOUND = "Program can`t find this file.";

        public static string EMPTY_FILE = "The file, which was choosen by you is empty";

        public static string WRONG_FILE_TYPE = "Please, choose file, which has file extension .txt";

        #endregion

        #endregion

    }
}
