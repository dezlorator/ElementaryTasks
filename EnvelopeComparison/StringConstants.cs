using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
    public class StringConstants
    {

        #region private

        public static string INPUT_ENVELOPE = "Enter the height and width of the envelope.";
        public static string FIRST_IN_SECOND = "First envelope can be put in a second one";
        public static string SECOND_IN_FIRST = "Second envelope can be put in a first one";
        public static string NONE_CAN_PUT = "None of the envelops can be put in another one";
        public static string IF_CONTINUE = "If you want to continue press y";
        public static string INFO_ABOUT_PROGRAMM = "This programm checks if one envelope can fit in another. You should write four float number.\n ";

        #region ErrorMessages

        public static string WRONG_ARGS_TYPE = "Your argument should be a float number";
        public static string WRONG_CONVERT_SIDE_SIZE = "Argument must be bigger than zero";
        public static string WRONG_NUMBER_OF_ARGUMENTS = "You should write two integers arguments";

        #endregion

        #endregion

    }
}
