using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    static class StringConstants
    {
        #region public

        public static string WELCOME_STRING = "Hello there. This programm takes file and find lucky tickets on it.\n ";

        public static string INFO_ABOUT_INPUT = "You should print values in such order - file path and searching mode\n" +
                                                "Available mods : Piter and Moskow algorithm";

        public static string OUTPUT_RESULT = "Number of lucky tickets = {0}";

        public static string MOSKOW_ALGORITHM_USED = "Moskow algorithm is choosen";

        public static string PITER_ALGORITHM_USED = "Piter algorithm is choosen";

        #region ErrorMessages

        public static string WRONG_ALGORITHM = "You wrote wrong algorithm";

        public static string WRITTEN_NOTHING = "You wrote nothing. Please, try again";

        public static string WRONG_NUMBER_OF_ARGUMENTS = "You wrote wrong number of arguments. Please, try again";

        public static string FILE_NOT_FOUND = "Program can`t find this file.";

        public static string EMPTY_FILE = "The file, which was choosen by you is empty";

        public static string WRONG_FILE_TYPE = "Please, choose file, which has file extension .txt";

        #endregion

        #endregion

    }
}
