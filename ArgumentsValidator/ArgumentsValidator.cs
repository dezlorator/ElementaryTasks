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
            if(argsArray != null)
            {
                return argsArray.Length == supposedLength;
            }
            throw new ArgumentNullException("Array can`t be a null value");
        }

        public bool CheckNumberRange(int number, int min, int max)
        {
            return (number >= min) && (number <= max);
        }

        public bool CheckDoubleNumberRange(double number, double min, double max)
        {
            return (number >= min) && (number <= max);
        }

        public bool IsEmpty(string stringToCheck)
        {
            if(stringToCheck != null)
            {
                return stringToCheck == "";
            }
            throw new ArgumentNullException("String can`t be a null value");
        }

        public bool TryParseInteger(string stringToParse, ref int outputNumber)
        {
            if (stringToParse != null)
            {
                return int.TryParse(stringToParse, out outputNumber);
            }
            throw new ArgumentNullException("String can`t be a null value");
        }

        public bool TryParseDouble(string stringToParse, ref double outputNumber)
        {
            if (stringToParse != null)
            {
                return double.TryParse(stringToParse, out outputNumber);
            }
            throw new ArgumentNullException("String can`t be a null value");
        }
    }
}
