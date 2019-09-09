using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentsValidator
{
    public class ArgsValidator : IArgumentsValidator
    {
        public bool CheckArgsArrayLength(string[] argsArray, int supposedLength)
        {
            return argsArray.Length == supposedLength;
        }

        public bool CheckNumberRange(int number, int min, int max)
        {
            return (number > min) && (number < max);
        }

        public bool CheckDoubleNumberRange(double number, double min, double max)
        {
            return (number > min) && (number < max);
        }

        public bool IsEmpty(string stringToCheck)
        {
            return stringToCheck == "";
        }

        public bool TryParseInteger(string stringToParse, ref int outputNumber)
        {
            return int.TryParse(stringToParse, out outputNumber);
        }

        public bool TryParseDouble(string stringToParse, ref double outputNumber)
        {
            return double.TryParse(stringToParse, out outputNumber);
        }
    }
}
