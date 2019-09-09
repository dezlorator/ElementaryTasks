using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentsValidator
{
    public interface IArgumentsValidator
    {
        bool CheckArgsArrayLength(string[] argsArray, int supposedLength);
        bool CheckNumberRange(int number, int min, int max);
        bool CheckDoubleNumberRange(double number, double min, double max);
        bool TryParseInteger(string stringToParse, ref int outputNumber);
        bool TryParseDouble(string stringToParse, ref double outputNumber);
        bool IsEmpty(string stringToCheck);
    }
}
