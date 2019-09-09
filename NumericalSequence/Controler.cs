using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientUI;
using ArgumentsValidator;

namespace NumericalSequence
{
    class Controler
    {
        #region private

        IArgumentsValidator argumentsValidator;

        private const int SIZE_OF_THE_ARGUMENTS_ARRAY = 1;

        #endregion

        public void Run(string[] args)
        {
            UI.ConsoleOutPut(StringConstants.WELCOME_STRING);
            int number = 0;

            if(!CheckArguments(args, ref number))
            {
                return;
            }

            NumericalSequenceCreator numericalSequence = GetSequance(number);
            RunWithSequence(numericalSequence);

        }

        private NumericalSequenceCreator GetSequance(int number)
        {
            return new NumericalSequenceCreator(number);
        }

        private void RunWithSequence(NumericalSequenceCreator sequence)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var i in sequence)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(", ");
            }
            stringBuilder.Length -= 2;

            UI.ConsoleOutPut(stringBuilder.ToString());
        }

        private void Intialize()
        {
            argumentsValidator = new ArgsValidator();
        }

        private bool CheckArguments(string[] args, ref int number)
        {
            bool IsCorrect = true;
            Intialize();

            if (!argumentsValidator.CheckArgsArrayLength(args, SIZE_OF_THE_ARGUMENTS_ARRAY))
            {
                UI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);
                IsCorrect = false;
            }
            else if(!argumentsValidator.TryParseInteger(args[0], ref number))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_INPUT);
                IsCorrect = false;
            }

            return IsCorrect;
        }
    }
}
