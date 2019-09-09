using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientUI;
using ArgumentsValidator;

namespace Fibonacci
{
    class Controler
    {
        #region private

        IArgumentsValidator argumentsValidator;

        private const int SIZE_OF_THE_ARGUMENTS_ARRAY = 2;

        #endregion

        public void Run(string[] args)
        {
            UI.ConsoleOutPut(StringConstants.WELCOME_STRING);
            int minValue = 0;
            int maxValue = 0;
            if(!CheckArguments(args, ref minValue, ref maxValue))
            {
                return;
            }

            NumericalFibonacciSequenceCreator numericalSequence = GetFibonacciSequance(minValue, maxValue);
            RunWithSequence(numericalSequence);

        }

        private NumericalFibonacciSequenceCreator GetFibonacciSequance(int minValue, int maxValue)
        {
            return new NumericalFibonacciSequenceCreator(minValue, maxValue);
        }

        private void RunWithSequence(NumericalFibonacciSequenceCreator sequence)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var i in sequence)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(", ");
            }
            if(stringBuilder.Length != 0)
            {
                stringBuilder.Length -= 2;
                UI.ConsoleOutPut(stringBuilder.ToString());
            }
            else
            {
                UI.ConsoleOutPut(StringConstants.NO_FIBONACCI_NUMBER);
            }
        }

        private void Intialize()
        {
            argumentsValidator = new ArgsValidator();
        }

        private bool CheckArguments(string[] args, ref int minNumber, ref int maxNumber)
        {
            bool IsCorrect = true;
            Intialize();

            if (!argumentsValidator.CheckArgsArrayLength(args, SIZE_OF_THE_ARGUMENTS_ARRAY))
            {
                UI.ConsoleOutPut(StringConstants.WRONG_NUMBER_OF_ARGUMENTS);
                IsCorrect = false;
            }
            else if(!argumentsValidator.TryParseInteger(args[0], ref minNumber))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_INPUT);
                IsCorrect = false;
            }
            else if (!argumentsValidator.TryParseInteger(args[1], ref maxNumber))
            {
                UI.ConsoleOutPut(StringConstants.INFO_ABOUT_INPUT);
                IsCorrect = false;
            }

            return IsCorrect;
        }

    }
}
