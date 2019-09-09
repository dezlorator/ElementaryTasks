using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeComparison
{
    public class CommandArgumentsParser : ICommandArgumentsParser
    {
        public string[] SplitStringIntoArray(string stringToSplit)
        {
            return stringToSplit.Split(new string[] { ", ", " "}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
