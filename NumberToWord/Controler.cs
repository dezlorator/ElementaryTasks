using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgumentsValidator;
using ClientUI;

namespace NumberToWord
{
    class Controler
    {
        #region private

        private IArgumentsValidator argumentsValidator;

        private const int ARGUMENTS_ARRAY_LENGTH = 1;

        private const int INDEX_OF_WORD_IN_ARRAY = 0;

        #endregion

        public Controler()
        {
            argumentsValidator = new ArgsValidator();
        }

        public void Run(string[] Arguments)
        {
            int number = 0;
            if(!CheckArguments(Arguments, ref number))
            {
                return;
            }
            UI.ConsoleOutPut(number.NumberToWords());
        }

        private bool CheckArguments(string[] Arguments, ref int integerFormOfNumber)
        {
            bool IsCorrect = true;
            if (!argumentsValidator.CheckArgsArrayLength(Arguments, ARGUMENTS_ARRAY_LENGTH))
            {
                UI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);
                IsCorrect = false;
            }
            else if(argumentsValidator.IsEmpty(Arguments[INDEX_OF_WORD_IN_ARRAY]))
            {
                UI.ConsoleOutPut(StringConstants.WRITTEN_NOTHING);
                IsCorrect = false;
            }
            else if (!argumentsValidator.TryParseInteger(Arguments[INDEX_OF_WORD_IN_ARRAY],ref integerFormOfNumber))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_TYPES);
                IsCorrect = false;
            }

            return IsCorrect;
        }
    }
}
